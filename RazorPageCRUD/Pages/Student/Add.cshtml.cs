using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageCRUD.Data;

namespace RazorPageCRUD
{
    public class AddModel : PageModel
    {
        private readonly IStudentRepository _studentRepository;
        public AddModel(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public void OnGet()
        {
        }

        [BindProperty]
        public Student Student { get; set; }

        public IActionResult OnPostSave()
        {
            _studentRepository.Add(Student);
            return RedirectToPage("List");
        }
    }
}