using EFTraining.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFTraining.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly EFTraining.Data.EFTrainingContext _context;

        public IndexModel(EFTraining.Data.EFTrainingContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get; set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}