using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FPOManagement.Models;

namespace FPOManagement.Pages.MemberGroups
{
    public class EditModel : PageModel
    {
        private readonly FPOManagement.Models.FPOManagementContext _context;

        public EditModel(FPOManagement.Models.FPOManagementContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(MemberGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MemberGroupExists(MemberGroup.MemberGroupID))
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

        private bool MemberGroupExists(int id)
        {
            return _context.MemberGroup.Any(e => e.MemberGroupID == id);
        }
    }
}
