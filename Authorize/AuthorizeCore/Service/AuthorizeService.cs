using AuthorizeCore.Interface;
using AuthorizeCore.Model;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;

namespace AuthorizeCore.Service
{
    public class AuthorizeService : IAuthorizeService
    {
        private UserInfo? userInfo;

        public UserInfo? GetUserInfo() { return userInfo; }
        public void ClearUserInfo() { userInfo = null; }
        public UserInfo? AuthenticateUser(string domain, string userName)
        {
            var correctDomains = new []
            {
                "OFFICEKIEV",
                "BUSINESSUKRAINE",
                "OFFICEUKRAINE",
                "BUSINESSKIEV", 
                "FZ"
            };

            if (correctDomains.Contains(domain.ToUpper()))
                userInfo = DomainSearch(userName, null, domain);

            return userInfo;
        }
        public UserInfo? AuthenticateUser(string domain, string userName, string password)
        {
            UserInfo? userInfo = null;
            PrincipalContext domainContext;
            try
            {
                domainContext = new PrincipalContext(ContextType.Domain, domain);
                if (string.IsNullOrEmpty(domainContext.ConnectedServer)) ;
            }
            catch
            {
                throw new Core.CustomException.CustomException("Неверный домен");
            }

            if (!domainContext.ValidateCredentials(userName, password))
            {
                throw new Core.CustomException.CustomException("Невірний пароль або ім'я користувача");
            }

            userInfo = DomainSearch(userName, password, domain);


            return userInfo;
        }

        private UserInfo? DomainSearch(string userName, string? password, string userDomainName)
        {
            DirectoryEntry entry;

            if (password == null)
                entry = new DirectoryEntry($"LDAP://{userDomainName}");
            else
                entry = new DirectoryEntry($"LDAP://{userDomainName}", userName, password);

            using (DirectorySearcher searcher = new DirectorySearcher(entry))
            {
                try
                {
                    searcher.Filter = $"(sAMAccountName={userName})";
                    searcher.PropertiesToLoad.Add("displayName");
                    searcher.PropertiesToLoad.Add("thumbnailPhoto");
                    SearchResult result = searcher.FindOne();

                    if (result != null)
                    {
                        entry.Dispose();
                        return new UserInfo
                        {
                            UserDomainName = userDomainName,
                            UserName = userName,
                            DisplayName = result.Properties["displayName"][0].ToString(),
                            ThumbnailPhoto = result.Properties["thumbnailPhoto"][0] as byte[]
                        };
                    }
                }
                catch
                {
                    // ignored
                }

                entry.Dispose();
                return new UserInfo
                {
                    UserName = Environment.UserName
                };
            }
        }
    }
}
