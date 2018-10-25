using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FPOManagement.Models;

namespace FPOManagement.Pages.FPOPromoters
{
    public class EditModel : PageModel
    {
        private readonly FPOManagement.Models.FPOManagementContext _context;

        public EditModel(FPOManagement.Models.FPOManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(FPOPromoter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FPOPromoterExists(FPOPromoter.BusinessID))
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

        private bool FPOPromoterExists(int id)
        {
            return _context.FPOPromoter.Any(e => e.BusinessID == id);
        }
    }
}
