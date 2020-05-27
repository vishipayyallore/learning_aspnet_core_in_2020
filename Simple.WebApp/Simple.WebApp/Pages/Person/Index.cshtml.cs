using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Simple.WebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Simple.WebApp.Pages.Person
{
    public class IndexModel : PageModel
    {
        private readonly Simple.WebApp.Data.SimpleWebAppContext _context;

        public IndexModel(Simple.WebApp.Data.SimpleWebAppContext context)
        {
            _context = context;
        }

        public IList<PersonInformation> Person { get;set; }

        public async Task OnGetAsync()
        {
            Person = await _context.Persons.ToListAsync();
        }
    }
}
