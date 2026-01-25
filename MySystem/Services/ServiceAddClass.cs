using MySystem.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySystem.Models;
namespace MySystem.Services
{
    public class ServiceAddClass
    {
        //public void AddClass(string ClassName, string Section, string AcademicYear, int TeacherID ,int Capacity, DateTime Create)
        //{
        //    using var db = new TaskDBContext();

        //    var newClass = new Class
        //    {
        //        ClassName = ClassName,
        //        Section = Section,
        //        AcademicYear = AcademicYear,
        //        ClassTeacherID = TeacherID,
        //        CreatedDate = Create
        //    };

        //    db.Add(newClass);
        //    db.SaveChanges();
        //    db.Entry(newClass).Reference(c => c.ClassTeacher).Load();

        //    Panel card = CreateClassCard(newClass);
        //    flowLayoutPanelClasses.Controls.Add(card);

        //    ClearInputs();
        //}
    }
}
