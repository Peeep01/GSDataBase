using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSDataBase.DB.Model
{
    public class Predmet
    {
        [Key]

        public int PredmetId { get; set; }
        public string PredmetName { get; set; }
    }
}
