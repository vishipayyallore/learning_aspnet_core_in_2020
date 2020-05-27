using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Simple.WebApp.Data;
using Simple.WebApp.Models;

namespace Simple.WebApp.Pages.Person
{
    public class DetailsModel : PageModel
    {
        private readonly Simple.WebApp.Data.SimpleWebAppContext _context;

        public DetailsModel(Simple.WebApp.Data.SimpleWebAppContext context)
        {
            _context = context;
        }

        public PersonInformation Person { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Person = await _context.Persons.FirstOrDefaultAsync(m => m.Id == id);

            if (Person == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
