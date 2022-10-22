using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAppWithoutMVCFolder.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["EmpName"] = "Shiva";
        }

        
        public IActionResult OnPostEditEmployee()
        {

            ViewData["EmpName"] = "Bharti";

            return Page();
        }

        public IActionResult OnPostSaveEmployee()
        {

            ViewData["EmpName"] = "Minkal";

            return Page();
        }
    }
}
