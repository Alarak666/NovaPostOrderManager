namespace AuthorizeCore.Model
{
    public class UserInfo
    {
        public string? UserName { get; set; }
        public string? UserDomainName { get; set; }        
        public string? DisplayName { get; set; }
        public byte[]? ThumbnailPhoto {  get; set; }
    }
}