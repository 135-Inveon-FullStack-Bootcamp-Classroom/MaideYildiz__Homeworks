using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorsPatients.Classes
{
    public class Doctor:Human
    {
        public int doctorId { get; set; }
        public string field { get; set; }

        public override void patientOrDoctor()
        {
            Console.WriteLine("This is a doctor");
        }
    }
}
