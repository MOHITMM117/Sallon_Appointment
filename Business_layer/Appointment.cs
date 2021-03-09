using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sallon_Appointment.Business_layer{
    //Appointment 
    public class Appointment
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public int HairDresserId { get; set; }

        public int HairDressingOptionId { get; set; }

        public Client Client { get; set; }

        public Hairdresser Hairdresser { get; set; }

        public HairCut HairCut { get; set; }



    }
}