using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorsPatients.Classes
{
    public class Patient:Human
    {
        public int patientID { get; set; }
        public string disease { get; set; }

        public override void patientOrDoctor()
        {
            Console.WriteLine("This is a patient.");
        }
    }
}
