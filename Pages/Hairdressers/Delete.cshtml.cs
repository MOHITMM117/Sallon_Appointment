using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sallon_Appointment.Business_layer;
using Sallon_Appointment.Data;

namespace Sallon_Appointment.Pages.Hairdressers
{
    public class DeleteModel : PageModel
    {
        private readonly Sallon_Appointment.Data.Sallon_AppointmentContext _context;

        public DeleteModel(Sallon_Appointment.Data.Sallon_AppointmentContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Hairdresser Hairdresser { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Hairdresser = await _context.Hairdresser.FirstOrDefaultAsync(m => m.Id == id);

            if (Hairdresser == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Hairdresser = await _context.Hairdresser.FindAsync(id);

            if (Hairdresser != null)
            {
                _context.Hairdresser.Remove(Hairdresser);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
