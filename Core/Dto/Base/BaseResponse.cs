namespace Core.Dto.Base
{
    public class BaseResponse<T> where T : class
    {
        public bool success { get; set; }
        public List<T> data { get; set; }
        //public List<string> errors { get; set; }
        //public List<string> warnings { get; set; }
        //public List<string> info { get; set; }
        //public List<string> messageCodes { get; set; }
        //public List<string> errorCodes { get; set; }
        //public List<string> warningCodes { get; set; }
        //public List<string> infoCodes { get; set; }
    }
}
