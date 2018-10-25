using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FPOManagement.Models;

namespace FPOManagement.Pages.FPOs
{
    public class EditModel : PageModel
    {
        private readonly FPOManagement.Models.FPOManagementContext _context;

        public EditModel(FPOManagement.Models.FPOManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["AuditorID"] = new SelectList(_context.Set<Auditor>(), "BusinessID", "BusinessName");
           ViewData["FPOPromoterID"] = new SelectList(_context.Set<FPOPromoter>(), "BusinessID", "BusinessName");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(FPO).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FPOExists(FPO.BusinessID))
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

        private bool FPOExists(int id)
        {
            return _context.FPO.Any(e => e.BusinessID == id);
        }
    }
}
