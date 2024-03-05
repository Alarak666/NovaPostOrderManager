using Core.Dto.SearchSettlement;

namespace Core.Dto.Base
{
    public class BaseRequest<T> where T : class
    {
        public string apiKey { get; set; }
        public string modelName { get; set; }
        public string calledMethod { get; set; }
        public T methodProperties { get; set; }
    }
}

