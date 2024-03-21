using MyLib;

namespace ApplicationManager.Services.SupportService
{
    public class GetLogService
    {
        private readonly string _user;
        private readonly Mail _mail;

        public GetLogService()
        {
            _mail = new Mail("smtp.fozzy.lan", "j-mp-kv-kras2o-b01", "P@ssw0rd2oo9");
        }


        public async Task SendEmail(string toEmail, string subject, string message, string[] attachments)
        {
            _mail.Send(subject, message, "j-mp-kv-kras2o-b01@fozzy.ua", "Лог нової пошти", [toEmail], attachments);
        }
        public async Task SendLogToEmail(string toEmail, string[] attachments)
        {
            string subject = "Менеджер нової пошти";
            string body = CreateEmailBody();
            await SendEmail(toEmail, subject, body, attachments);
        }
        public string CreateEmailBody()
        {
            var htmlBody = $@"
        <html>
        <head>
            <title>Менеджер нової пошти</title>
        </head>
        <body>
            <p><strong>Щось упало!</strong></p>
            <p>Вам потрібно це відремонтувати.</p>
        </html>";
            return htmlBody;
        }
    }
}
