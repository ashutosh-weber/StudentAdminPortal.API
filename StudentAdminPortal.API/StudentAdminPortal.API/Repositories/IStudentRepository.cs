using StudentAdminPortal.API.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Repositories
{
    public interface IStudentRepository
    {

        Task<List<Student>> GetStudentsAsync();  ////this  method is a syncronus method after we will chnge sync 
        Task<Student> GetStudentAsync(Guid studentId);
        Task<List<Gender>> GetGendersAsync();

        Task<bool>Exists(Guid studentId);  //this method is take student guid id 

        Task<Student> UpdateStudent(Guid studentId, Student request);

        


    }
}
