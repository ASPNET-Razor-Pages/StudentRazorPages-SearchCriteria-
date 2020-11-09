using StudentRazorPages_SearchCriteria_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRazorPages_SearchCriteria_.Services
{
    public class FakeStudentRepository
    {
        public Dictionary<int, Student> DictList { get; set; }
        public FakeStudentRepository()
        {
            // declare object reference
            DictList = new Dictionary<int, Student>();
            // fill values 
            DictList.Add(22, new Student() { Id = 1, Name = "alex", ImagePath = "alex.jpg" });
            DictList.Add(33, new Student() { Id = 2, Name = "john", ImagePath = "john.jpg" });
            DictList.Add(44, new Student() { Id = 3, Name = "nilma", ImagePath = "nilma.jpg" });
            DictList.Add(55, new Student() { Id = 4, Name = "aljo", ImagePath = "alex.jpg" });
            DictList.Add(66, new Student() { Id = 5, Name = "anni", ImagePath = "john.jpg" });
            DictList.Add(77, new Student() { Id = 6, Name = "jojo", ImagePath = "nilma.jpg" });


        }
        public  Dictionary<int, Student> GetStudents()
        {
            return DictList;
        }

        // Add new items in the current List 

        public void AddStudent(Student newStudent)
        {
            DictList.Add(newStudent.Id, newStudent);
        }
    }
}
