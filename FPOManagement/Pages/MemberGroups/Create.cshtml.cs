﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FPOManagement.Models;

namespace FPOManagement.Pages.MemberGroups
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
            return Page();
        }

        [BindProperty]
        public MemberGroup MemberGroup { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MemberGroup.Add(MemberGroup);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}