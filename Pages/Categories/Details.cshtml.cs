using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dobos_Stefania_Lab2._1.Data;
using Dobos_Stefania_Lab2._1.Models;

namespace Dobos_Stefania_Lab2._1.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Dobos_Stefania_Lab2._1.Data.Dobos_Stefania_Lab2_1Context _context;

        public DetailsModel(Dobos_Stefania_Lab2._1.Data.Dobos_Stefania_Lab2_1Context context)
        {
            _context = context;
        }

      public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);
            if (category == null)
            {
                return NotFound();
            }
            else 
            {
                Category = category;
            }
            return Page();
        }
    }
}
