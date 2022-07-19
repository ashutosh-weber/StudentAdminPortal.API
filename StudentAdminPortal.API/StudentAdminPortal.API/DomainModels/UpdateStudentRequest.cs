

using System;

namespace StudentAdminPortal.API.DomainModels
{
    public class UpdateStudentRequest
    {/*
                                                           // here we are not take id becoz we donmt want to change id field // 
                                                          *//* take property from student model*/
                                                          /*We not take profile url because we have already a seprate ffunction*/ 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }

        public string Email { get; set; }

        public long Mobile { get; set; }
        public Guid GenderId { get; set; }
        public string PhysicalAddress { get; set; }

        public string PostalAddress { get; set; }

    }
}
