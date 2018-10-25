using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FPOManagement.Models;

namespace FPOManagement.Pages.FPOPromoters
{
    public class DetailsModel : PageModel
    {
        private readonly FPOManagement.Models.FPOManagementContext _context;

        public DetailsModel(FPOManagement.Models.FPOManagementContext context)
        {
            _context = context;
        }

        public FPOPromoter FPOPromoter { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FPOPromoter = await _context.FPOPromoter.FirstOrDefaultAsync(m => m.BusinessID == id);

            if (FPOPromoter == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
