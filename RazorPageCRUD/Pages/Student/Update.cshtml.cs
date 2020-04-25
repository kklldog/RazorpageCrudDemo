using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageCRUD.Data;

namespace RazorPageCRUD
{
    public class UpdateModel : PageModel
    {
        private readonly IStudentRepository _studentRepository;
        public UpdateModel(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public void OnGet(int id)
        {
            Student = _studentRepository.Get(id);
        }

        [BindProperty]
        public Student Student { get; set; }

        public IActionResult OnPostEdit(Student student)
        {
            _studentRepository.Update(student);

            return RedirectToPage("List");
        }
    }
}