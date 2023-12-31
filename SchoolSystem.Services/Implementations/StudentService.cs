using SchoolSystem.Data.Entities;
using SchoolSystem.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemSchool.InfraStructure.Abstracts;
using SystemSchool.InfraStructure.Repositories;

namespace SchoolSystem.Services.Implementations
{
    public class StudentService : IStudentService
    {
        #region Fields
        private readonly IStudentRepository _studentRepository;


        #endregion
            
        #region Constructors
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        #endregion

        #region HandleFunctions
        public async Task<List<Student>> GetStudentsListAsync()
        {
           return await  _studentRepository.GetAllStudentsAsync();
        }

        #endregion




    }
}
