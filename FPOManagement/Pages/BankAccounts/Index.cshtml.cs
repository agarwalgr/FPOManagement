﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FPOManagement.Models;

namespace FPOManagement.Pages.BankAccounts
{
    public class IndexModel : PageModel
    {
        private readonly FPOManagement.Models.FPOManagementContext _context;

        public IndexModel(FPOManagement.Models.FPOManagementContext context)
        {
            _context = context;
        }

        public IList<BankAccount> BankAccount { get;set; }

        public async Task OnGetAsync()
        {
            BankAccount = await _context.BankAccount.ToListAsync();
        }
    }
}
