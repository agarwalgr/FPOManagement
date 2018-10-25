using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FPOManagement.Models;

namespace FPOManagement.Pages.FPOs
{
    public class DetailsModel : PageModel
    {
        private readonly FPOManagement.Models.FPOManagementContext _context;

        public DetailsModel(FPOManagement.Models.FPOManagementContext context)
        {
            _context = context;
        }

        public FPO FPO { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FPO = await _context.FPO
                .Include(f => f.Auditor)
                .Include(f => f.FPOPromoter).FirstOrDefaultAsync(m => m.BusinessID == id);

            if (FPO == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
