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
    public class IndexModel : PageModel
    {
        private readonly FPOManagement.Models.FPOManagementContext _context;

        public IndexModel(FPOManagement.Models.FPOManagementContext context)
        {
            _context = context;
        }

        public IList<FPO> FPO { get;set; }

        public async Task OnGetAsync()
        {
            FPO = await _context.FPO
                .Include(f => f.Auditor)
                .Include(f => f.FPOPromoter).ToListAsync();
        }
    }
}
