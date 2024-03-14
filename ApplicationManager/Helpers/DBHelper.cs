using Core.Constants.DefaultValues;
using MyLib;

namespace ApplicationManager.Helpers
{
    public static class DBHelper
    {
        public static (SQL sql, LogFile logFile) Init(LogFile? logFile = null)
        {
            return (new SQL(
                $"Data Source={CoreDefaultValues.Server};User ID={CoreDefaultValues.User};Password={CoreDefaultValues.Password};"), logFile ?? new LogFile(@"C:\Work\NovaPostOrderManager\Log.txt"));
        }
    }
}
