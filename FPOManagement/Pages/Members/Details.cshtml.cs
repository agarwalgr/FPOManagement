using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FPOManagement.Models;

namespace FPOManagement.Pages.Members
{
    public class DetailsModel : PageModel
    {
        private readonly FPOManagement.Models.FPOManagementContext _context;

        public DetailsModel(FPOManagement.Models.FPOManagementContext context)
        {
            _context = context;
        }

        public Member Member { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Member = await _context.Member
                .Include(m => m.FPO)
                .Include(m => m.MemberGroup).FirstOrDefaultAsync(m => m.ID == id);

            if (Member == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
