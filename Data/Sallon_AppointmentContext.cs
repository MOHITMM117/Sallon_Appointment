using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sallon_Appointment.Business_layer;

namespace Sallon_Appointment.Data
{
    public class Sallon_AppointmentContext : DbContext
    {
        public Sallon_AppointmentContext (DbContextOptions<Sallon_AppointmentContext> options)
            : base(options)
        {
        }

        public DbSet<Sallon_Appointment.Business_layer.Appointment> Appointment { get; set; }

        public DbSet<Sallon_Appointment.Business_layer.Client> Client { get; set; }

        public DbSet<Sallon_Appointment.Business_layer.HairCut> HairCut { get; set; }

        public DbSet<Sallon_Appointment.Business_layer.Hairdresser> Hairdresser { get; set; }
    }
}
