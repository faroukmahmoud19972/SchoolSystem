using SchoolSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemSchool.InfraStructure.InfraStructureBases;

namespace SystemSchool.InfraStructure.Abstracts
{
    public interface IStudentRepository : IGenericRepositoryAsync<Student>
    {
        public Task <List<Student>> GetAllStudentsAsync();
        public Task<Student> GetStudentByIdAsync(int id);

    }
}
