using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageCRUD.Data;

namespace RazorPageCRUD
{
    public class DeleteModel : PageModel
    {
        private readonly IStudentRepository _studentRepository;
        public DeleteModel(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void OnGet(int id)
        {
            Student = _studentRepository.Get(id);
        }

        public Student Student { get; set; }

        public IActionResult OnPostDelete(int id)
        {
            _studentRepository.Delete(id);

            return RedirectToPage("list");
        }
    }
}