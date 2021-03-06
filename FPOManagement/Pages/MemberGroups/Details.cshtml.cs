﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FPOManagement.Models;

namespace FPOManagement.Pages.MemberGroups
{
    public class DetailsModel : PageModel
    {
        private readonly FPOManagement.Models.FPOManagementContext _context;

        public DetailsModel(FPOManagement.Models.FPOManagementContext context)
        {
            _context = context;
        }

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
    }
}
