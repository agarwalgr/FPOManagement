using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FPOManagement.Models;

namespace FPOManagement.Pages.Members
{
    public class CreateModel : PageModel
    {
        private readonly FPOManagement.Models.FPOManagementContext _context;

        public CreateModel(FPOManagement.Models.FPOManagementContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["FPOID"] = new SelectList(_context.Set<FPO>(), "BusinessID", "Discriminator");
        ViewData["MemberGroupID"] = new SelectList(_context.Set<MemberGroup>(), "MemberGroupID", "MemberGroupID");
            return Page();
        }

        [BindProperty]
        public Member Member { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Member.Add(Member);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}