using File_Backup_Service.Dtos;

namespace File_Backup_Service.Interface
{
    public interface IBackupRepo
    {
        Task<List<FileDirectoryDto>> GetBackupDirectory();
    }
}
