using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sallon_Appointment.Business_layer;
using Sallon_Appointment.Data;

namespace Sallon_Appointment.Pages.Hairdressers
{
    public class EditModel : PageModel
    {
        private readonly Sallon_Appointment.Data.Sallon_AppointmentContext _context;

        public EditModel(Sallon_Appointment.Data.Sallon_AppointmentContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Hairdresser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HairdresserExists(Hairdresser.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool HairdresserExists(int id)
        {
            return _context.Hairdresser.Any(e => e.Id == id);
        }
    }
}
