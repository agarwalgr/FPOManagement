using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FPOManagement.Models;

namespace FPOManagement.Pages.MemberGroups
{
    public class DeleteModel : PageModel
    {
        private readonly FPOManagement.Models.FPOManagementContext _context;

        public DeleteModel(FPOManagement.Models.FPOManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MemberGroup MemberGroup { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MemberGroup = await _context.MemberGroup.FirstOrDefaultAsync(m => m.MemberGroupID == id);

            if (MemberGroup == null)
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

            MemberGroup = await _context.MemberGroup.FindAsync(id);

            if (MemberGroup != null)
            {
                _context.MemberGroup.Remove(MemberGroup);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
