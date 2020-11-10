using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using StudentRazorPages_SearchCriteria_.Model;
using StudentRazorPages_SearchCriteria_.Services;

namespace StudentRazorPages_SearchCriteria_.Pages
{
    public class IndexModel : PageModel
    {
        // bindable property into UI
        public Dictionary<int, Student> Students { get; set; }
        public FakeStudentRepository Repo { get; set; }

        [BindProperty(SupportsGet =true)]
        public string SearchCriteria { get; set; } 

        // Binding Student Property
        [BindProperty]
        public Student Student { get; set; }

        public IndexModel(FakeStudentRepository repo)
        {
            Repo = repo;
            Students = Repo.GetStudents();
        }
        public IActionResult OnGet()    
        {
            
            // Check filter criteria here 
            if(!String.IsNullOrEmpty(SearchCriteria))
            {
                Students = FilterResult(SearchCriteria);
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            // add new student
            Repo.AddStudent(Student);
            return RedirectToAction("OnGet");
            
        }
        private Dictionary<int, Student> FilterResult(string searchCriteria)
        {
            Dictionary<int, Student> filterResults = new Dictionary<int, Student>();
            foreach(var student in Students.Values)
            {
                if (student.Name.StartsWith(searchCriteria))
                {
                    filterResults.Add(student.Id, student);
                }
            }
            return filterResults;
        }
    }
}
