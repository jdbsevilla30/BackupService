using System;
using System.Collections.Generic;

namespace BackupService.Data.Model.BackupService;

public partial class FileDirectory
{
    public int Id { get; set; }

    public int? DirectoryId { get; set; }

    public string? DirectoryName { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
