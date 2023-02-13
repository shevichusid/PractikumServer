using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public enum Sex
    {
        Male,Female
    }
    public enum Pharmecy
    {
        Clalit, Meuchedet,Leumit,Macabi
    }
    public class Parent
    {
        public string ParentId { get; set; }
        public string FirstName{ get; set; } 
        public string LastName { get; set; }
        public string TZ { get; set; }
        public DateTime DateOfBirth { get; set; }   
        public Sex Sex { get; set; }
        public Pharmecy Pharmecy { get; set; }   
        public int Children { get; set; }
    }
}
