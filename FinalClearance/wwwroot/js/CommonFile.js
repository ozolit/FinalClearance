

function initializeHeaderMenu() {
    
    var list = document.getElementsByClassName("hl");
    alert("Menu initialized");
    //var list = document.getElementsByClassName("hl");
    for (var i = 0; i < list.length; i++) {
        addHandler(list[i], "click", function (evt) {
            // invokeIframe("changeHeaderMenu", evt)
           
            if (evt.target.className.match("hl") != null) {
                
                clearMenu("hl", "hl header-menu")
                evt.target.className = "hl header-menu-selected";
                var d = get(evt.target.dataset.page);
                
                if (activeDiv != d) {
                    $(activeDiv).slideUp("fast", function () {
                        $(d).slideDown("slow", function () {
                            /* resizing()*/
                            
                        })
                        activeDiv = d;
                        
                    });
                }

            }
            else {
                clearMenu("hl", "hl header-menu")
            }
        })

    }
}



function clearMenu(selector, _default) {
    var list = document.getElementsByClassName(selector)
    for (var i = 0; i < list.length; i++) {
        list[i].className = _default;
    }
}

function getStateId() {
    try {
        addHandler(get("StateId"), "change", getLgaByStateId);
    } catch (e) {
        alert(e.message);
    }
}

function getLgaByStateId() {
    try {
        alert("Get All LGAs in the State");
        var selectState = get("StateId");
        var selectStateId = selectState.options[selectState.selectedIndex].value;

        var stateObject = {};
        stateObject.State = { Id: selectStateId };
        alert(JSON.stringify(stateObject));

        JqueryAjaxServiceCall(JSON.stringify(stateObject), "GetLgaByStateId", "../../../Common/Common", function (lgaListId) {

            if (lgaListId.length > 0) {
                var lgaId = document.getElementById("LgaId");
                AddItems(lgaListId, lgaId)
            } else {
                alert("No Data");
            }
        });

    } catch (e) {
        alert(e.message);
    }
}

function getCountryId() {
    try {
        alert("Ese");

        addHandler(get("countryId"), "change", getStateIdByCountryId);
    } catch (e) {
        alert(e.message);
    }
}

function getStateIdByCountryId() {
    try {
        alert("Get All States in the Country");
        var selectCountry = get("countryId");
        var selectCountryId = selectCountry.options[selectCountry.selectedIndex].value;

        var countryObject = {};
        countryObject.Country = { Id: selectCountryId };
        JqueryAjaxServiceCall(JSON.stringify(countryObject), "GetStateIdByCountryId", "../../../Common/Common", function (stateListId) {
            if (stateListId.length > 0) {
                var stateId = document.getElementById("StateId");
                AddItems(stateListId, stateId)
            } else {
                alert("No Data");
            }

        });


    } catch (e) {
        alert(e.message);
    }
}

function getDepartmentId() {
    addHandler(get("FacultyId"), "change", getDepartmentByFacultyId);
    alert("Get My Department");
}
//department = [];
function getDepartmentByFacultyId() {
    try {
        alert("Get All Department");
        var selectFaculty = get("FacultyId");
        var selectFacultyId = selectFaculty.options[selectFaculty.selectedIndex].value;

        var facultyIdObject = {};
        facultyIdObject.Faculty = { Id: selectFacultyId };
        alert(JSON.stringify(facultyIdObject));
        JqueryAjaxServiceCall(JSON.stringify(facultyIdObject), "getDepartmentByFacultyId", "../../../Common/Common", function (departmentList) {
            var departmentId = document.getElementById("departmentId");
            if (departmentList.length > 0) {
                alert(departmentList);
                
                AddItems(departmentList, departmentId)

                //for (var i = 0; i < departments.length; i++) {
                //    var department = departments[i];
                //    var cloneDepartment = departmentIdContainer.cloneNode(true);
                //    alert(department.Name);
                //    get("facultiId", cloneDepartment).options = department.Name;
                //    departmentIdContainer.appendChild(departmentId);

                //}
            } else {
                RemoveChildren(departmentId);

                alert("No data");
            }
        });

    } catch (e) {
        alert(e.message);
    }
}
function getProgrammeId() {
    addHandler(get("departmentId"), "change", getProgrammeByDepartmentId);
}

//function getProgrammeByDepartmentId() {
//    alert("programmeId");
//    var selectDepartment = get("departmentId");
//    var selectDepartmentId = selectDepartment.options[selectDepartment.selectedIndex].value;

//    var departmentObject = {};
//    departmentObject.department = { Id: selectDepartmentId };
//    JqueryAjaxServiceCall(JSON.stringify(departmentObject), "getProgrammeByDepartmentId", "../../../Common/Common", function (programmeList){
//        var programmeId = document.getElementById("ProgrammeId");
//        if (programmeList.length > 0) {
//            alert(programmeList);

//            AddItems(programmeList, programmeId);

//        } else {
//            RemoveChildren(programmeId);

//            alert("No data");
//        }
//    })
//}

//function getFacultyId() {
//    addHandler(get("SchoolId"), "change", getFacultyBySchoolId);

//}

//var faculty = [];
//function getFacultyBySchoolId() {
//    try {
//        alert("get All Faculty")
//        var selectSchool = get("SchoolId");
//        var selectSchoolId = selectSchool.options[selectSchool.selectedIndex].value;
//        alert(selectSchoolId);

//        var getFacultyByIdObject = {};
//        getFacultyByIdObject.School = { Id: selectSchoolId };

//        JqueryAjaxServiceCall(JSON.stringify(getFacultyByIdObject), "getFacultyBySchoolId", "../../../Common/Common", function (facultyList) {
//            var facultiId = document.getElementById("facultyId");
//            if (facultyList.length > 0) {
//                alert(8)
//                AddItems(facultyList, facultiId)
//                //alert(facultyList);
//                //faculties = facultyList;
//                //var facultyIdContainer = document.getElementById("facultyIdContainer");
//                //var facultiId = document.getElementById("facultiId");
//                //for (var i = 0; i < faculties.length; i++) {
//                //    var faculty = faculties[i];
//                //    var cloneFacultyId = facultyIdContainer.cloneNode(true);
//                //    alert(faculty.Name);
//                //    get("facultiId", cloneFacultyId).options = faculty.Name;
//                //    facultyIdContainer.appendChild(facultiId);

//                //}
//            } else {
//                RemoveChildren(facultiId);

//                alert("No data");
//                facultiId.value = "0";
//            }
//        });
//    } catch (e) {
//        alert(e.message);
//    }
//}
//var btnMoveToTop = document.getElementById("moveToTop");
//function scrollFunction() {

//    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
//        btnMoveToTop.style.display = "block";
//    } else {
//        btnMoveToTop.style.display = "none";
//    }
//}

// When the user clicks on the button, scroll to the top of the document
function topFunction() {
    //document.body.scrollTop = 0; // For Safari
    //document.documentElement.scrollTop = 0; // For Chrome, Firefox, IE and Opera

    $('html, body').animate({ scrollTop: 0 }, 'slow');
}

// When the user clicks on the button, Modal Element will close

function closeModalWindow(event) {
    if (event.target == modal) {
        modal.style.display = "none";
        //alert(1);
    }

}


// This toggles the menu in dashboard
function toggleMenu(currentId) {
    var currentElement = get(currentId)
    var displayStatus = currentElement.style.display;

    var list = document.getElementsByClassName("p");
    for (var i = 0; i < list.length; i++) {
        list[i].style.display = "none";
    }

    if (displayStatus == "block") {
        currentElement.style.display = "none";
    } else {
        currentElement.style.display = "block";
    }
}
//displays te preloader of any page or action
function showLoader() {
    setTimeout(showPage, 900);
}

// reduces the size of the menu to custom icons

function reduceSideMenu() {
    try {
        // alert("button clicked");
        var sideMenuReduce = document.getElementById("MenuParent");

        if (this.isReduced == undefined) {
            sideMenuReduce.style.width = "200px";
            this.isReduced = true;
        }
        else {
            sideMenuReduce.style.width = "50px";
            this.isReduced = undefined;

        }
    }
    catch (e) {
        alert(e.message())
    }

}

function initializeSideBarMenuTab() {

    var list = document.getElementsByClassName("nav-link");

    for (var i = 0; i < list.length; i++) {
        addHandler(list[i], "click", function (evt) {
            localStorage.setItem("main-tab", this.id);  

        })

    }
}


function initializeSideBarMenuItem() {

    var list = document.getElementsByClassName("collapse-item");

    for (var i = 0; i < list.length; i++) {
        addHandler(list[i], "click", function (evt) {

            localStorage.setItem("menu-item", this.id);

        })

    }
}

//Place this function in every pageload event that inherited from common layout
function menuDisplayControl() {
    initializeSideBarMenuTab();
    initializeSideBarMenuItem();

    var menuItemId = localStorage.getItem("menu-item");
    var maintab = localStorage.getItem("main-tab");
    document.getElementById(maintab).click();
    document.getElementById(menuItemId).style.backgroundColor = "#eaecf4";
}

//Displays the dynamic menus in dashboard
//function initializeHeaderMenu() {
//    var list = document.getElementsByClassName("hl");

//    //var list = document.getElementsByClassName("hl");
//    for (var i = 0; i < list.length; i++) {
//        addHandler(list[i], "click", function (evt) {
//            // invokeIframe("changeHeaderMenu", evt)

//            if (evt.target.className.match("hl") != null) {
//                clearMenu("hl", "hl header-menu")
//                evt.target.className = "hl header-menu-selected";
//                var d = get(evt.target.dataset.page);
//                if (activeDiv != d) {
//                    $(activeDiv).hide("fast", function () {
//                        $(d).show("slow", function () {
//                            /* resizing()*/
//                        })
//                        activeDiv = d;
//                    });
//                }

//            }
//            else {
//                clearMenu("hl", "hl header-menu")
//            }
//        })

//    }
//}


//erase the selected html elements
function clearMenu(selector, _default) {
    var list = document.getElementsByClassName(selector)
    for (var i = 0; i < list.length; i++) {
        list[i].className = _default;
    }
}

// controls the database assync communication
function JqueryAjaxServiceCall(serviceData, methodToCall, serviceUrl, successMethod) {

    var _url = serviceUrl + "/" + methodToCall
    return $.ajax({
        type: "POST",
        contentType: "application/json; charset=utf-8",
        url: _url,
        data: serviceData,
        dataType: "json",
        success: successMethod,
        error: function (msg) {

            alert(msg.responseText);
        }
    });
    //$.getJSON(serviceUrl + "/" + methodToCall, serviceData, successMethod)
    // $.post(serviceUrl + "/" + methodToCall, serviceData, successMethod,"json")


}
// handles hide and show of the element that holds the loader
function showPage() {
    document.getElementById("loader").style.display = "none";
    document.getElementById("myDiv").style.display = "block";
}
//used to Identof the Id of elements
function get(id, parent) {

    if (parent != undefined) {
        return parent.querySelector("#" + id)
    } else {
        return document.getElementById(id);
    }
}

// used to clear table row that is deleted
function clearContainer(element) {
    while (element.children.length > 0) {
        element.children[0].removeChild(element.children[0]);
    }
}

// to upload the selected image 
function GetSelectedItemValueType(element, message, valueType) {

    var option = element.options[element.selectedIndex];

    //alert(1);

    if (valueType == "value") {
        if (option.value != "0") {
            return option.value;
        }
        ThrowException(message);
    }
    else {
        if (option.value != "0") {
            return option.innerHTML;
        }
        ThrowException(message);
    }

}

// through exception

function ThrowException(message) {

    var e = new Error();
    e.message = message;

    throw e;
}
// to validate the user input
function checkInput(input, message) {
    var t = input.type;
    if ((t == "text" || t == "email" || t == "number" || t == "data" || t == "time" || t == "color" || t == "tel" || t == "url" || t == "week" || t == "datetime-local" || t == "month" || t == "date" || t == "hidden") || input.type == "password" || input.type == "textarea" || input.type == "hidden") {
        if (input.value.trim() != null && input.value.trim() != "") {
            return input.value;
        }
        ThrowException(message, input, input.VerticalDown)
    }
    else {
        if (input.innerHTML.trim() != null && input.innerHTML.trim() != "") {
            return input.innerHTML
        }
        ThrowException(message, input, input.VerticalDown)
    }

}

//handle the various event
function addHandler(element, event, handler) {
    element.addEventListener(event, handler);
}
// to validate file
function validateFile(file, message) {
    var fileInput = document.getElementById(file);
    var filePath = fileInput.value;
    var allowedExtesions = /(\.jpg | \.jpeg | \.png | \.gif)$/i;
    if (!allowedExtesions.exec(filePath)) {
        alert('Invalid file type');
        fileInput.value = '';
        return false;

    } else {
        //image preview
        if (fileInput.files && fileInput.files[0]) {
            var reader = new fileReader();
            reader.onload = function (e) {
                document.getElementById(e).innerHTML = '<img src="' + e.target.result + '"/>';
            };
            reader.readAsDataURL(fileInput.files[0]);
        }
    }
}

function ImageAnimation(action) {
    var ele = get("loader");

    ele.className = action;
}



function centerAnimation() {
    var ele = get("loader");
    setToCenterOfParent(ele, window)
    ele.className = "show";

}

function setToCenterOfParent(element, parent, vertical) {

    parentWidth = $(parent).width();
    parentHeight = $(parent).height();
    elementWidth = $(element).width();
    elementHeight = parseInt($(element).height());
    //alert(elementHeight + " " + elementWidth)
    $(element).css('left', (parentWidth / 2) - (elementWidth / 2));
    if (vertical == undefined) {
        $(element).css('top', (parentHeight / 2) - (elementHeight / 2));
    } else {
        //$(element).css(vertical, 60);
        $($get("myNav3")).animate({ bottom: "60px" }, 200);

    }

}


function AddItems(list, dllElement, includeDefault) {
    try {
        RemoveChildren(dllElement);
        if (includeDefault == undefined) {
            var option1 = document.createElement("option");
            option1.innerHTML = "--select Opton--";
            option1.value = "0";
            dllElement.appendChild(option1);
        }

        for (var i = 0; i < list.length; i++) {
            var item = list[i];
            var option = document.createElement("option");
            option.innerHTML = item.text;
            option.value = item.value;
            if (item.value < 0) {
                option.style.color = "blue"
            }
            dllElement.appendChild(option)
        }
    }
    catch (e) {
        alert(e.message)
    }
}
function RemoveChildren(element) {
    while (element.options.length > 0) {
        element.options[0].parentNode.removeChild(element.options[0])
    }
}