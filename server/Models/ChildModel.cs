using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class ChildModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string FatherTZ { get; set; }
        public string ChildName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string TZ { get; set; }
    }
}
