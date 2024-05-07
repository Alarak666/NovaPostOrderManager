using Core.Constants.DefaultValues;
using MyLib;

namespace ApplicationManager.Helpers
{
    public static class DBHelper
    {
        public static (SQL sql, LogFile logFile) Init(LogFile? logFile = null)
        {
            return (new SQL(
                $"Data Source={CoreDefaultValues.Server};User ID={CoreDefaultValues.User};Password={CoreDefaultValues.Password};"), logFile ?? new LogFile(@"Log.txt"));
        }
        public static (SQL sql, LogFile logFile) InitRemove(LogFile? logFile = null)
        {
            return (new SQL(
                $"Data Source=sfpv-sqls018.fz.fozzy.lan;User ID=Developer_1c;Password=kHI5Adu8arXKsS3m7sDY37wRaRD37XBL;Initial Catalog=InternetSaleApteka;"), logFile ?? new LogFile(@"Log.txt"));
        }
    }
}
