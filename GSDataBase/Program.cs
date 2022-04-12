using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GSDataBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyContext myContext = new MyContext();

            List<DB.Model.Group> groups = myContext.Groups.ToList();

            var marks = myContext.StudentMarks.Include(x=>x.Student).Include(x =>x.Predmet).ToList();

            foreach (var it in marks)
            {
                Console.WriteLine($"{it.Student.Name} - оценка - {it.Mark} по предмету {it.Predmet.PredmetName}"); // может быть очень большим
            }






            //var st = myContext.Students.Where(x => x.Name.StartsWith("S")).OrderByDescending
            //    (x => x.Name).OrderByDescending
            //    (x => x.Group.Name).ToList();

            //foreach (var item in st)
            //{
            //    Console.WriteLine($"{item.Name} - {item.Group.Name} ");
            //}
            Console.ReadLine();
        }
    }
}
