using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AlphaTechnoWeb.Pages
{
    public class DownloadModel : PageModel
    {
        private readonly IHostingEnvironment hostingEnvironment;
        public DownloadModel(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
        }

        public PhysicalFileResult OnGet()
        {
            string path = Path.Combine(hostingEnvironment.WebRootPath, "content", @"alpha-technologies-profile.pdf");
            return new PhysicalFileResult(path, "application/pdf"); // Change to the right mime type
        }
    }
}
