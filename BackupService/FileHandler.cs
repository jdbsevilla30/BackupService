namespace BackupService
{
    public class BackupService
    {
        public BackupService()
        {
          

        }


        class DirectoryPath       //will be moved as Model once my scaffold works
        {
            public int DirectoryId { get; set; }
            public string? DirectoryName { get; set; }
            public string? DestinationFolder { get; set; }    
        }


        public void FileWatcher(string path)
        {

            //test  data until the migration worked
            List<DirectoryPath> directories = new List<DirectoryPath>();
            // Adding multiple directory instances to the list
            directories.Add(new DirectoryPath { DirectoryName = "", DestinationFolder = "", DirectoryId = 1 });
            directories.Add(new DirectoryPath { DirectoryName = "", DestinationFolder = "", DirectoryId = 2 });
            directories.Add(new DirectoryPath { DirectoryName = "", DestinationFolder = "", DirectoryId = 3 });

          try
            {
                foreach (var directoryList in directories)
                {
                    int directoryId = directoryList.DirectoryId;
                    string directoryName = directoryList.DirectoryName;

                    if (Directory.Exists(directoryName))
                    {
                        var allFiles = ListAllFiles(directoryName);
                        CopyFiles(allFiles, path);
                    }
                    else
                    {
                        //log to database that the specified directory is not existing.
                        //
                        Console.WriteLine("FileWatcher", $"The directory path {directoryName} does not exist.", "Error Code: ", 1);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

        public string[] ListAllFiles(string directoryPath)
        {
            try
            {
                if (Directory.Exists(directoryPath))
                {
                    string[] searchPatterns = { "*.csv", "*.xlsx", "*.xls" };
                    List<string> fileList = new List<string>();

                    foreach (string searchPattern in searchPatterns)
                    {
                        fileList.AddRange(Directory.GetFiles(directoryPath, searchPattern, System.IO.SearchOption.AllDirectories));
                    }
                    return fileList.ToArray();
                }
                else
                {
                    return new string[0];
                }
            }
            catch (Exception ex)
            {
                //log the error    
            throw;
            }
        }

        public void CopyFiles(string[] files, string destinationDirectory)
        {
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                string originalFile = $"{destinationDirectory}\\Original"; 
                string originalFilePath = Path.Combine($"{destinationDirectory}\\Original", fileInfo.Name);
   
                // create path if not exist
                Directory.CreateDirectory(originalFile);
                Directory.CreateDirectory(destinationDirectory); 
                // Check if the file already exists in the destination directory
                if (!File.Exists(originalFilePath))
                {
                    File.Copy(file, originalFilePath);
                }
                else
                {
                 //add logging
                }
            }
        }

    }
}