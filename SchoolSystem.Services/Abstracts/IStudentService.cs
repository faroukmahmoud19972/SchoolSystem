using SchoolSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Services.Abstracts
{
    public interface IStudentService
    {
        public Task <List<Student>> GetStudentsListAsync ();  
    }
}
