using System.Linq;
using FourApplication.Models;
using Microsoft.AspNetCore.Mvc;
namespace AdminPanelTutorial
{
    public class SubjectsController : Controller
    {
        MyDbContext db = new MyDbContext();
        public ActionResult Index()
        {
            return View(db.Subjects.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Createsubject(Subjects subject){
            db.Subjects.Add(subject);
            db.SaveChanges();
            return RedirectToAction("Index", "Subjects");
        }
        [HttpPost]
        public bool Delete(int id){
            try
            {
                Subjects subject = db.Subjects.Where(s => s.Id == id).First();
                db.Subjects.Remove(subject);
                db.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
            
        }
        public ActionResult Update(int id){
            return View(db.Subjects.Where(s => s.Id == id).First());
        }
        [HttpPost]
        public ActionResult Updatesubject(Subjects subject){
            Subjects d = db.Subjects.Where(s => s.Id == subject.Id).First();
            d.Name = subject.Name;
          
            db.SaveChanges();
            return RedirectToAction("Index", "Subjects");
        }
        //   [HttpPost]
        // public ActionResult Updatesubject(Subjects subject){
        //     Subjects d = db.Subjects.Where(s => s.Id == subject.Id).First();
        //     d.Name = subject.Name;
          
        //     db.SaveChanges();
        //     return RedirectToAction("Index", "Subjects");
        // }
        
    }
}