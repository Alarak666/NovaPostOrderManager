using AuthorizeCore.Interface;
using AuthorizeCore.Service;
using Core.CustomException;
using LoginFailedException = AuthorizeCore.CustomException.LoginFailedException;

namespace Authorize.WinForm
{
    public partial class FormAuthorize : Form
    {
        private readonly IAuthorizeService _service;
        public string UserName;
        public FormAuthorize()
        {
            InitializeComponent();
            _service = new AuthorizeService();

        }
        private void Form_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!CBCurrentUserLogin.Checked)
                {
                    if (TDomain.TextLength == 0)
                        TDomain.Focus();
                    else if (TLogin.TextLength == 0)
                        TLogin.Focus();
                    else if (TPassword.TextLength == 0)
                        TPassword.Focus();
                    else
                        BLogin.PerformClick();
                }
                else
                    BLogin.PerformClick();
            }
        }
        private void BLogin_Click(object sender, EventArgs e)
        {
            var userInfo = _service.GetUserInfo();

            if (userInfo is null)
            {
                string domain = TDomain.Text;
                string username = TLogin.Text;
                string password = TPassword.Text;

                userInfo = _service.AuthenticateUser(domain, username, password);

                if (string.IsNullOrEmpty(userInfo?.UserName))
                    throw new LoginFailedException();
            }

            UserName = userInfo.DisplayName;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Application.Exit();
        }

        private void CBCurrentUserLogin_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                TDomain.Enabled = TLogin.Enabled = TPassword.Enabled = !CBCurrentUserLogin.Checked;

                if (CBCurrentUserLogin.Checked)
                {
                    var userInfo = _service.AuthenticateUser(Environment.UserDomainName, Environment.UserName);
                    TDomain.Text = userInfo.UserDomainName;
                    TLogin.Text = userInfo.UserName;
                    if (userInfo != null && userInfo.ThumbnailPhoto != null && userInfo.ThumbnailPhoto.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(userInfo.ThumbnailPhoto))
                        {
                            Image thumbnailImage = Image.FromStream(ms);
                            UserImage.Image = thumbnailImage;
                        }
                    }
                }
                else
                {
                    TDomain.Text = "";
                    TLogin.Text = "";
                    UserImage.Image = Resource.Resource.userDefault;
                    _service.ClearUserInfo();
                }
            }
            catch 
            {
                throw new AuthorizeException("У вас немає дозволу на використання, зверніться до адміністратора");
            }
        }
    }
}
