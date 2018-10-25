using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FPOManagement.Models;

namespace FPOManagement.Pages.Auditors
{
    public class DeleteModel : PageModel
    {
        private readonly FPOManagement.Models.FPOManagementContext _context;

        public DeleteModel(FPOManagement.Models.FPOManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Auditor Auditor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Auditor = await _context.Auditor.FirstOrDefaultAsync(m => m.BusinessID == id);

            if (Auditor == null)
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

            Auditor = await _context.Auditor.FindAsync(id);

            if (Auditor != null)
            {
                _context.Auditor.Remove(Auditor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
