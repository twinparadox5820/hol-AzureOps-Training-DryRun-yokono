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
    public class DetailsModel : PageModel
    {
        private readonly AzureOps_SampleApp.Data.AzureOps_SampleAppContext _context;

        public DetailsModel(AzureOps_SampleApp.Data.AzureOps_SampleAppContext context)
        {
            _context = context;
        }

      public Person Person { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Person == null)
            {
                return NotFound();
            }

            var person = await _context.Person.FirstOrDefaultAsync(m => m.PersonId == id);
            if (person == null)
            {
                return NotFound();
            }
            else 
            {
                Person = person;
            }
            return Page();
        }
    }
}
