using File_Backup_Service.Dtos;
using File_Backup_Service.Interface;
using BackupService.Data.Model.BackupService;
using Microsoft.EntityFrameworkCore;

namespace File_Backup_Service.Repositories;
public class BackupRepo : IBackupRepo
{

    private readonly FileBackupServiceContext _context;


    public BackupRepo(FileBackupServiceContext context)
    {
        _context = context;
    }

   public Task<List<FileDirectory>> GetBackupDirectory()
    {
       return  _context.FileDirectories.ToListAsync();
   }
}
