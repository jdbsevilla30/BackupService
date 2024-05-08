using BackupService.Data.Model.BackupService;
using File_Backup_Service.Interface;

namespace File_Backup_Service.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FileBackupServiceContext _fileBackupServiceContext;
        
        public UnitOfWork(FileBackupServiceContext fileBackupServiceContext)
        {
            _fileBackupServiceContext = fileBackupServiceContext;
        }

        public IBackupRepo backupRepo => new BackupRepo(_fileBackupServiceContext);

        public async Task<bool> Complete()
        {
            return await _fileBackupServiceContext.SaveChangesAsync() > 0;
        }

        public void Dispose()
        {
            _fileBackupServiceContext.Dispose();
        }
    }
}
