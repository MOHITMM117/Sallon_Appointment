using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sallon_Appointment.Business_layer
{
    //Hair dresser details
    public class Hairdresser
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsPermanent { get; set; }
    }
}