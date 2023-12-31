using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemSchool.InfraStructure.Abstracts;
using SystemSchool.InfraStructure.Context;

namespace SystemSchool.InfraStructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        #region fields

        private readonly ApplicationDbContext _applicationDbContext;

        #endregion

        #region ctor
        public StudentRepository(ApplicationDbContext applicationDbContext) 
        {
            _applicationDbContext = applicationDbContext;
        }


        #endregion

        #region HandleFunctions
        public async Task<List<Student>> GetAllStudentsAsync()
        {
            var students = await _applicationDbContext.Student.Include(x=>x.Department).ToListAsync();

            return students;
        }

        #endregion


    }
}   
