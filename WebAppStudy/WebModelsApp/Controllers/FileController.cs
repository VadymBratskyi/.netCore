using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace WebModelsApp.Controllers
{  
    public class FileController : Controller
    {
        private readonly IHostingEnvironment _env;

        public FileController(IHostingEnvironment env) {
            _env = env;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetFile() {

            string fl_path = Path.Combine(_env.ContentRootPath, "Files/text.txt");

            string fl_type = "application/txt";

            string fl_name = "text.txt";

            return PhysicalFile(fl_path, fl_type, fl_name);

        }

        public FileResult GetFileByte() {

            string fl_path = Path.Combine(_env.ContentRootPath, "Files/text.txt");

            byte[] mas = System.IO.File.ReadAllBytes(fl_path);

            string fl_type = "application/txt";

            string fl_name = "text.txt";

            return File(mas, fl_type, fl_name);
        }

        public FileResult GetFileStream()
        {

            string fl_path = Path.Combine(_env.ContentRootPath, "Files/txtX.xlsx");

            FileStream fs = new FileStream(fl_path, FileMode.Open);

            string fl_type = "application/xlsx";

            string fl_name = "textX.xlsx";

            return File(fs, fl_type, fl_name);
        }

        public VirtualFileResult GetVirtualFile()
        {

            string fl_path = Path.Combine("~/files", "text.txt");

            string fl_type = "application/txt";

            string fl_name = "text.txt";

            return File(fl_path, fl_type, fl_name);
        }

        public IActionResult GetMessage() {
            return PartialView("_GetMessage");
        }
    }
}