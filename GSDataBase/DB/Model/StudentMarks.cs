using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSDataBase.DB.Model
{
    public class StudentMarks
    {
        [Key]
        public int Id { get; set; }
        public string Mark { get; set; }
        public DateTime Date { get; set; }
       

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int PredmetId { get; set; }
        public Predmet Predmet { get; set; }
    }
}
