using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSDataBase.DB.Model
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        public string Name { get; set; }
    }
}
