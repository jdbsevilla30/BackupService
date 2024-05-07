using BackupService.Data.Model.BackupService;
using File_Backup_Service.Dtos;

namespace File_Backup_Service.Interface
{
    public interface IBackupRepo
    {
        Task<List<FileDirectory>> GetBackupDirectory();
    }
}
