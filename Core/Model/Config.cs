namespace Core.Model
{
    public class Config
    {
        public string Version { get; set; } = string.Empty;
        public string ProgramName { get; set; } = string.Empty;
        public string ApplicationName { get; set; } = string.Empty;
        public string LocalPath { get; set; } = string.Empty;
        public string RemotePath { get; set; } = string.Empty;
        public List<MyFile>? Files { get; set; }
    }
}