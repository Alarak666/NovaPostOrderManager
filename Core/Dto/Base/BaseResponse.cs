namespace Core.Dto.Base
{
    public class BaseResponse<T> where T : class
    {
        public bool success { get; set; }
        public List<T> data { get; set; }
        public List<object>? errors { get; set; }
        public List<object>? warnings { get; set; }
        public object? info { get; set; }
        public List<object>? messageCodes { get; set; }
        public List<object>? errorCodes { get; set; }
        public List<object>? warningCodes { get; set; }
        public List<object>? infoCodes { get; set; }
    }

    public class ResponseInfo
    {
        public int totalCount { get; set; }
    }
}
