var activeDiv;
function pageLoad() {
    try {
        var listFaculty = document.getElementById("facultyId");
        listFaculty.addEventListener("change", fillDepartment);
        //addHandler("facultyId", "change", fillDepartment);
    }
    catch (e) {
        alert(e.message);
    }
}

//function initializeHeaderMenu() {

//    var list = document.getElementsByClassName("hl");
//    alert("Menu initialized");
//    //var list = document.getElementsByClassName("hl");
//    for (var i = 0; i < list.length; i++) {
//        addHandler(list[i], "click", function (evt) {
//            // invokeIframe("changeHeaderMenu", evt)

//            if (evt.target.className.match("hl") != null) {

//                clearMenu("hl", "hl header-menu")
//                evt.target.className = "hl header-menu-selected";
//                var d = get(evt.target.dataset.page);

//                if (activeDiv != d) {
//                    $(activeDiv).slideUp("fast", function () {
//                        $(d).slideDown("slow", function () {
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

function fillDepartment() {
    try {
        var listFaculty = document.getElementById("facultyId"); 
        alert(1);
        var facultyId = listFaculty.options[listFaculty.selectedIndex].value;
       // alert(facultyId)
        let department = {};
        department.Faculty = { Id: facultyId };
        JqueryAjaxServiceCall(JSON.stringify(department), "getDepartmentById", "../Settings", function (listDepartent) {
            if (listDepartent.length > 0) {
                alert(JSON.stringify(listDepartent));
                var listDepartmentId = document.getElementById("departmentId");
                AddItems(listDepartent, listDepartmentId);
            } else if (listDepartent.length == 0) {
                alert("No Option");
            } else {
                alert("Select option with value");
            }
            
        })
    }
    
    catch (e) {
        alert(e.message);
    }
        
}

//function get(id, parent) {

//    if (parent != undefined) {
//        return parent.querySelector("#" + id)
//    } else {
//        return document.getElementById(id);
//    }
//}





