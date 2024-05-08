using AutoMapper;
using BackupService.Data.Model.BackupService;
using File_Backup_Service.Dtos;

namespace File_Backup_Service.Helper
{
    public class AutoMapperProfile : Profile
    {
       public AutoMapperProfile() 
        {
            //file backup service mapping
            CreateMap<FileDirectoryDto, FileDirectory>();
        }


    }
}
