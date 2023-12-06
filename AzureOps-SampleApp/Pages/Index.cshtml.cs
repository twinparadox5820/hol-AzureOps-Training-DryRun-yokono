using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AzureOps_SampleApp.Data;
using AzureOps_SampleApp.Models;

namespace AzureOps_SampleApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AzureOps_SampleApp.Data.AzureOps_SampleAppContext _context;

        public IndexModel(AzureOps_SampleApp.Data.AzureOps_SampleAppContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Person != null)
            {
                Person = await _context.Person.ToListAsync();
            }
        }
    }
}
