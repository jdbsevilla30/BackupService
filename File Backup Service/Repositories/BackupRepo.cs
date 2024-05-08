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
        return _context.FileDirectories.ToListAsync();
    }

public bool DuplicateCheck(FileDirectory fileDirectory)
    {
        var duplicateChecker = _context.FileDirectories.FirstOrDefault(x => x.DirectoryName == fileDirectory.DirectoryName);

        if (duplicateChecker != null)
        {
            return true;
        }
        return false;
    }
    public void AddBackupDirectory(FileDirectory fileDirectory)
    {
        _context.FileDirectories.Add(fileDirectory);
        _context.SaveChanges();
    }

    public void UpdateBackupDirectory(FileDirectory fileDirectory)
    {
        _context.FileDirectories.Update(fileDirectory);
        _context.SaveChanges();
    }

    public void DeleteBackupDirectory(FileDirectory fileDirectory)
    {
        _context.FileDirectories.Remove(fileDirectory);
        _context.SaveChanges();
    }



}
