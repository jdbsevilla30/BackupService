using File_Backup_Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace File_Backup_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
 
    public class FileBackupController : ControllerBase
    {
        private readonly IBackupRepo _backupRepo;

        [HttpGet("GetDirectory")]
        public void GetDirectory()
        {
            var item = _backupRepo.GetBackupDirectory(); 
        
        }
    }
}