﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FPOManagement.Models;

namespace FPOManagement.Pages.FPOs
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
        ViewData["AuditorID"] = new SelectList(_context.Set<Auditor>(), "BusinessID", "Discriminator");
        ViewData["FPOPromoterID"] = new SelectList(_context.Set<FPOPromoter>(), "BusinessID", "Discriminator");
            return Page();
        }

        [BindProperty]
        public FPO FPO { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.FPO.Add(FPO);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}