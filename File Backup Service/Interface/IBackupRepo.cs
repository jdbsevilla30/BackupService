using BackupService.Data.Model.BackupService;
using File_Backup_Service.Dtos;

namespace File_Backup_Service.Interface
{
    public interface IBackupRepo
    {
        public Task<List<FileDirectory>> GetBackupDirectory();
        public bool DuplicateCheck(FileDirectory fileDirectory);
        public void AddBackupDirectory(FileDirectory fileDirectory);
        public void UpdateBackupDirectory(FileDirectory fileDirectory);
        public void DeleteBackupDirectory(FileDirectory fileDirectory);
 
    }
}
