using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorsPatients.Classes
{
    public abstract class Human
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public abstract void patientOrDoctor();
        

    }
}
