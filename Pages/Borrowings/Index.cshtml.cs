using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dobos_Stefania_Lab2._1.Data;
using Dobos_Stefania_Lab2._1.Models;

namespace Dobos_Stefania_Lab2._1.Pages.Borrowings
{
    public class IndexModel : PageModel
    {
        private readonly Dobos_Stefania_Lab2._1.Data.Dobos_Stefania_Lab2_1Context _context;

        public IndexModel(Dobos_Stefania_Lab2._1.Data.Dobos_Stefania_Lab2_1Context context)
        {
            _context = context;
        }

        public IList<Borrowing> Borrowing { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Borrowing != null)
            {
                Borrowing = await _context.Borrowing
                .Include(b => b.Book)
                .ThenInclude(b => b.Author)
                .Include(b => b.Member).ToListAsync();
            }
        }
    }
}
