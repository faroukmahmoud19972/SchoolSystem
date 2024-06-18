using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemSchool.InfraStructure.Abstracts;
using SystemSchool.InfraStructure.Context;
using SystemSchool.InfraStructure.InfraStructureBases;

namespace SystemSchool.InfraStructure.Repositories
{
    public class StudentRepository :GenericRepositoryAsync<Student>, IStudentRepository
    {
        #region fields

        private readonly DbSet<Student> _StudentRepository;

        #endregion

        #region ctor
        public StudentRepository(ApplicationDbContext applicationDbContext) :base(applicationDbContext)
        {
            _StudentRepository = applicationDbContext.Set<Student>();
        }


        #endregion

        #region HandleFunctions
        public async Task<List<Student>> GetAllStudentsAsync()
        {
            var students = await _StudentRepository.Include(x=>x.Department).ToListAsync();

            return students;
        }

        public Task<Student> GetStudentByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        //public async Task<Student> GetStudentByIdAsync(int id)
        //{
        //    var student =await  _StudentRepository()
        //    return 
        //}

        #endregion


    }
}   
