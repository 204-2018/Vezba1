using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Veterinar
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Speciality { get; set; }
        public int YearsExperience { get; set; }

    }
}
