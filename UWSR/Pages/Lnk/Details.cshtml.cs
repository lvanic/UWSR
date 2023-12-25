using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UWSR.Data;
using UWSR.Models;

namespace UWSR.Pages.Lnk
{
    public class DetailsModel : PageModel
    {
        private readonly UWSR.Data.AppDbContext _context;

        public DetailsModel(UWSR.Data.AppDbContext context)
        {
            _context = context;
        }

      public Link Link { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Links == null)
            {
                return NotFound();
            }

            var link = await _context.Links.FirstOrDefaultAsync(m => m.Id == id);
            if (link == null)
            {
                return NotFound();
            }
            else 
            {
                Link = link;
            }
            return Page();
        }
    }
}
