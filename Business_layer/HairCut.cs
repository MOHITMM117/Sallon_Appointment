using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sallon_Appointment.Business_layer
{
    //Hair dressing options
    public class HairCut
    {
        public int Id { get; set; }

        public string OptionName { get; set; }

        public decimal Charge { get; set; }

    }
}