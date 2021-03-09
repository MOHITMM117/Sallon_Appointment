using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sallon_Appointment.Business_layer;
using Sallon_Appointment.Data;

namespace Sallon_Appointment.Pages.Appointments
{
    public class DetailsModel : PageModel
    {
        private readonly Sallon_Appointment.Data.Sallon_AppointmentContext _context;

        public DetailsModel(Sallon_Appointment.Data.Sallon_AppointmentContext context)
        {
            _context = context;
        }

        public Appointment Appointment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Appointment = await _context.Appointment
                .Include(a => a.Client)
                .Include(a => a.Hairdresser).FirstOrDefaultAsync(m => m.Id == id);

            if (Appointment == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
