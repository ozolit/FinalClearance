using FinalClearance.Data;
using FinalClearance.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Buffers.Text;

namespace FinalClearance.Controllers
{
    public class SettingsController : Controller
    {
        private readonly DbContext db;
        public SettingsController(DbContext _db)
        {
            db = _db;
        }
        public IActionResult Relationship()
        {
            return View();
        }
        public IActionResult Gender()
        {
            return View();
        }

        public IActionResult Faculty()
        {
            return View();
        }
        public IActionResult AdmissionType()
        {
            return View();
        }
        public IActionResult Session()
        {
            return View();
        }

        public IActionResult Level()
        {
            return View();
        }

        public IActionResult CreateGender(Gender gender)
        {
            List<Gender> entityGender = db.GENDER.Where(x => x.Name == gender.Name).ToList();
            if (entityGender.Count == 0)
            {
                if (ModelState.IsValid)
                {
                    db.GENDER.Add(gender);
                    db.SaveChanges();
                    TempData["success"] = "Gender Successfully created";
                    return RedirectToAction("Gender");
                }
            }
            else
            {
                ModelState.AddModelError("name", "Name already exists");
            }
            return View("Gender");
        }


        public IActionResult CreateRelationship(Relationship relationship)
        {
            List<Relationship> entityRelationship = db.RELATIONSHIP.Where(x => x.Name == relationship.Name).ToList();
            if (entityRelationship.Count == 0)
            {
                if (ModelState.IsValid)
                {
                    db.RELATIONSHIP.Add(relationship);
                    db.SaveChanges();
                    TempData["success"] = "Relationship Successfully created";
                    return RedirectToAction("Relationship");
                }
            }
            else
            {
                ModelState.AddModelError("name", "Name already exists");
            }
            return View("Relationship");
        }

        [HttpPost]
        public IActionResult CreateLevel(Level level)
        {
            List<Level> entityLevel = db.LEVEL.Where(x => x.Name == level.Name).ToList();
            if (entityLevel.Count == 0)
            {
                if (ModelState.IsValid)
                {
                    db.LEVEL.Add(level);
                    db.SaveChanges();
                    TempData["success"] = "Level Successfully created";
                    return RedirectToAction("Level");
                }
            }
            else
            {
                ModelState.AddModelError("name", "Name already exists");
            }
            return View("Level");
        }

        [HttpPost]
        public IActionResult CreateSession(Session session)
        {
            List<Session> entitySession = db.SESSION.Where(x => x.Name == session.Name).ToList();
            if(entitySession.Count == 0)
            {
                if (ModelState.IsValid)
                {
                    db.SESSION.Add(session);
                    db.SaveChanges();
                    TempData["success"] = "Session Successfully created";
                    return RedirectToAction("Session");
                }
            }
            else{
                ModelState.AddModelError("name", "Name already exists");
            }
            return View("Session");
        }

        [HttpPost]
        public IActionResult CreateAdmissionType(AdmissionType admissionType)
        {

            List<AdmissionType> entityAdmissionTypes = db.ADMISSIONTYPE.Where(x => x.Name == admissionType.Name).ToList();
            if (entityAdmissionTypes.Count == 0)
            {
                if (ModelState.IsValid)
                {
                    db.ADMISSIONTYPE.Add(admissionType);
                    db.SaveChanges();
                    TempData["success"] = "Admission Type successfully created";
                    return RedirectToAction("AdmissionType");
                }
            }
            else
            {
                ModelState.AddModelError("name", "Name already exists");
            }

            return View("AdmissionTye");
        }


        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateFaculty(Faculty facultyObj)
        {
            List<Faculty> entityFaculty = db.FACULTY.Where(x => x.Name == facultyObj.Name && x.Code == facultyObj.Code).ToList();
            if (entityFaculty.Count == 0)
            {
                if (ModelState.IsValid)
                {
                    if (facultyObj.Name == facultyObj.Code.ToString())
                    {
                        ModelState.AddModelError("name", "The Code cannot exactly Match the Name");
                    }
                    else
                    {
                        db.FACULTY.Add(facultyObj);
                        db.SaveChanges();
                        TempData["success"] = "Faculty successfully created";
                        return RedirectToAction("Faculty");

                    }
                }

            }
            else
            {
                ModelState.AddModelError("name", "Name already exists");
            }




            return View("Faculty");
        }

        private List<SelectListItem>getFaculty()
        {
            var listFaculty = new List<SelectListItem>();
            List<Faculty> faculties = db.FACULTY.ToList();
            listFaculty = faculties.Select(x => new SelectListItem()
            {
                Value = x.Id.ToString(),
                Text = x.Name
            }).ToList();
            var defitem = new SelectListItem()
            {
                Value = "",
                Text = "---Select Faculty--"
            };
            listFaculty.Insert(0, defitem);
            return listFaculty;
            
        }

        private List<SelectListItem> getFacultyy()
        {
            var listFaculty = new List<SelectListItem>();
            List<Faculty> faculties = db.FACULTY.ToList();
            listFaculty = faculties.Select(x => new SelectListItem()
            {
                Value = x.Id.ToString(),
                Text = x.Name
            }).ToList();
            var defitem = new SelectListItem()
            {
                Value = "",
                Text = "---Select Faculty--"
            };
            listFaculty.Insert(0, defitem);
            return listFaculty;

        }


        [HttpGet]
        public IActionResult Department()
        {
            Department department = new Department();
            ViewBag.FacultyId = getFaculty();
            return View(department);
        }

        [HttpGet]
        public IActionResult Programme()
        {
            Programme programme = new Programme();
            ViewBag.FacultyId = getFaculty();
            ViewBag.DepartmentId = getDepartment();
            return View(programme);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateDepartment(Department department)
        {
            try
            {
                List<Department> depart = db.DEPARTMENT.Where(x => x.Faculty.Id == department.Faculty.Id && x.Name == department.Name).ToList();
                if (depart.Count == 0)
                {


                    Department _Department = new Department();
                    _Department.FacultyId = department.Faculty.Id;
                    _Department.Name = department.Name;
                    _Department.Code = department.Code;
                    _Department.DateAdded = department.DateAdded;

                    db.DEPARTMENT.Add(_Department);
                    db.SaveChanges();
                    TempData["success"] = "Department successfully created";
                    return RedirectToAction("Department");
                }
                else
                {
                    //TempData["error"] = "Department already created";

                    ModelState.AddModelError("Name", "Name already exists");
                }



                return RedirectToAction("Department");
            }catch (Exception e)
            {
                return RedirectToAction("Department");
            }
        }

        [HttpGet]
        private List<SelectListItem> getDepartment()
        {
            var listDepartment = new List<SelectListItem>();
            List<Department> departments = db.DEPARTMENT.ToList();
            listDepartment = departments.Select(x => new SelectListItem()
            {
                Value = x.Id.ToString(),
                Text = x.Name
            }).ToList();
            var defitem = new SelectListItem()
            {
                Value = "",
                Text = "---Select Department--"
            };
            listDepartment.Insert(0, defitem);
            return listDepartment;

        }


        [HttpPost]
        //[Route("settings/getDepartmentById")]
        public IActionResult getDepartmentById([FromBody] Department department)
        {
            if (department == null)
            {
                return Json(1);
            }
            else
            {
                var listDepartent = new List<SelectListItem>();
                List<Department> departments = db.DEPARTMENT.Where(f => f.FacultyId == department.Faculty.Id).OrderBy(n => n.Name).ToList();
                if (departments.Count == 0)
                {
                    return Json(0);
                }
                listDepartent = departments.Select(x => new SelectListItem()
                {
                    Value = x.Id.ToString(),
                    Text = x.Name
                }).ToList();
                //var defitem = new SelectListItem()
                //{
                //    Value = "",
                //    Text = "---Select Department--"
                //};
                ////listDepartent.Insert(0);
                return Json(listDepartent);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateProgramme(Programme programme)
        {
            try
            {
                List<Department> depart = db.DEPARTMENT.Where(x => x.Faculty.Id == programme.Department.Id && x.Name == programme.Name).ToList();
                if (depart.Count == 0)
                {


                    Programme _Programme = new Programme();
                    _Programme.FacultyId = programme.Faculty.Id;
                    _Programme.DepartmentId = programme.Department.Id;
                    _Programme.Name = programme.Name;
                    _Programme.Code = programme.Code;
                    _Programme.DateAdded = programme.DateAdded;

                    db.PROGRAMME.Add(_Programme);
                    db.SaveChanges();
                    TempData["success"] = "Programme successfully created";
                    return RedirectToAction("Programme");
                }
                else
                {
                    //TempData["error"] = "Department already created";

                    ModelState.AddModelError("Name", "Name already exists");
                }



                return RedirectToAction("Department");
            }
            catch (Exception e)
            {
                return RedirectToAction("Department");
            }
        }

        


    }
}

