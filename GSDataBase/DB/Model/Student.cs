using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSDataBase.DB.Model
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; } // id группы
        public Group Group { get; set; } // навигационное поле
    }
}
