using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sallon_Appointment.Business_layer;
using Sallon_Appointment.Data;

namespace Sallon_Appointment.Pages.HairCuts
{
    public class IndexModel : PageModel
    {
        private readonly Sallon_Appointment.Data.Sallon_AppointmentContext _context;

        public IndexModel(Sallon_Appointment.Data.Sallon_AppointmentContext context)
        {
            _context = context;
        }

        public IList<HairCut> HairCut { get;set; }

        public async Task OnGetAsync()
        {
            HairCut = await _context.HairCut.ToListAsync();
        }
    }
}
