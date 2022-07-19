using AutoMapper;
using StudentAdminPortal.API.DomainModels;
using DataModels = StudentAdminPortal.API.DataModels;

using StudentAdminPortal.API.Profiles.AfterMaps;

namespace StudentAdminPortal.API.Profiles
{
    public class AutoMapperprofiles: Profile
    {
        public AutoMapperprofiles()
        {
            CreateMap<DataModels.Student, Student>()
                .ReverseMap();

            CreateMap<DataModels.Gender, Gender>()
                .ReverseMap();

            CreateMap<DataModels.Address, Address>()
                .ReverseMap();

            CreateMap<UpdateStudentRequest, DataModels.Student>()
                .AfterMap<UpdateStudentRequestAfterMap>();
              


        }
    }
}
