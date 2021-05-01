using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Courses.Models;
using Courses.ViewModels;
using System.Net;

namespace Courses.Controllers
{
    public class EnrollmentsController : Controller
    {
        private ApplicationDbContext db;

        public EnrollmentsController()
        {
            db = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }

        // GET: Enrollments
        
      /* public ActionResult Regi()
        {
            var admissions= db.Admissions.ToList();
            var majors = db.Majors.ToList();
            var courses = db.Courses.ToList();
            var students = db.Students.ToList();
            var viewModel = new NewEnrollmentViewModel
            {
                admissions = admissions,
                majors = majors,
                courses = courses,
                students = students
            };

            return View(viewModel);
        }*/

        public ActionResult Register()
        {
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "CourseName");
            ViewBag.StudentId = new SelectList(db.Students, "Id", "FirstName");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include = "StudentId,CourseId,TermCode,MajorId,Grade,EnrolledIndicator,PaymentIndicator")] Enrollment enrollment)
        {
            if (ModelState.IsValid)
            {
                db.Enrollments.Add(enrollment);
                db.SaveChanges();
                return RedirectToAction("list");
            }

            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "CourseName", enrollment.CourseId);
            ViewBag.StudentId = new SelectList(db.Students, "Id", "FirstName", enrollment.StudentId);
            return View(enrollment);
        }

        public ActionResult list()
        {
            var enrollments = db.Enrollments.Include(e => e.Course).Include(e => e.Student);
            return View(enrollments.ToList());
        }

        public ActionResult Details(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var students = db.Students.Find(id);
            var courses = db.Courses.ToList();
            var viewModel = new EmpStudViewModel
            {
                courses = courses,

                Student = students

        };

            if (viewModel == null)
            {
                return HttpNotFound();
            }
            return View(viewModel);
        }

        /* [HttpPost]
         [ValidateAntiForgeryToken]
         public ActionResult RegisterStudentInCourse(Enrollment enrollment)
         {
             if (!ModelState.IsValid)
             {
                 var admissions = db.Admissions.ToList();
                 var majors = db.Majors.ToList();
                 var courses = db.Courses.ToList();
                 var students = db.Students.ToList();
                 var viewModel = new NewEnrollmentViewModel
                 {
                     admissions = admissions,
                     majors = majors,
                     courses = courses,
                     students = students,
                     Enrollment = enrollment
                 };
                 return View("Register", viewModel);
             }
             db.Enrollments.Add(enrollment);
             db.SaveChanges();

             return RedirectToAction("Index", "Home");
         }*/

    }
}