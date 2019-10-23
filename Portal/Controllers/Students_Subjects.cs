using System.Linq;
using FourApplication.Models;
using Microsoft.AspNetCore.Mvc;
namespace AdminPanelTutorial
{
    public class Students_SubjectsController : Controller
    {
        MyDbContext db = new MyDbContext();
        public ActionResult Index()
        {
            return View(db.Students_Subjects.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Createsubject(Students_Subjects subject){
            db.Students_Subjects.Add(subject);
            db.SaveChanges();
            return RedirectToAction("Index", "Students_Subjects");
        }
        [HttpPost]
        public bool Delete(int id){
            try
            {
                Students_Subjects subject = db.Students_Subjects.Where(s => s.Id == id).First();
                db.Students_Subjects.Remove(subject);
                db.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
            
        }
        public ActionResult Update(int id){
            return View(db.Students_Subjects.Where(s => s.Id == id).First());
        }
        [HttpPost]
        public ActionResult Updatesubject(Students_Subjects subject){
            Students_Subjects d = db.Students_Subjects.Where(s => s.Id == subject.Id).First();
           
          
            db.SaveChanges();
            return RedirectToAction("Index", "Students_Subjects");
        }
    }
}