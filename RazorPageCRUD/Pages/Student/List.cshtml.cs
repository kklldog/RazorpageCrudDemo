using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageCRUD.Data;

namespace RazorPageCRUD
{
    public class ListModel : PageModel
    {
        private readonly IStudentRepository _studentRepository;
        public List<Student> Students { get; set; }
        public ListModel(IStudentRepository studentRepository) 
        {
            _studentRepository = studentRepository;
        }

        public void OnGet()
        {
            Students = _studentRepository.List();
        }
    }
}