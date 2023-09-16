var activeDiv;
function pageLoad() {
    activeDiv = get("personalInformation-div");
    initializeHeaderMenu();
    var listFaculty = document.getElementById("facultyId");
    listFaculty.addEventListener("change", fillDepartment);
    //addHandler("facultyId", "change", fillDepartment);

}

function nextButton(nextButton) {

    var nextButton = document.getElementById("nextButton");
    nextButton.addEventListener()
}

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
