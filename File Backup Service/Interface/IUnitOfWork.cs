namespace File_Backup_Service.Interface
{
    public interface IUnitOfWork
    {
        IBackupRepo backupRepo { get; }
    }
}
