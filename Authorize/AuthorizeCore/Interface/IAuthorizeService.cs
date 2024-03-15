using AuthorizeCore.Model;

namespace AuthorizeCore.Interface;

public interface IAuthorizeService
{
    UserInfo? GetUserInfo();
    void ClearUserInfo();
    UserInfo? AuthenticateUser(string domain, string userName, string password);
    UserInfo? AuthenticateUser(string domain, string userName);
}