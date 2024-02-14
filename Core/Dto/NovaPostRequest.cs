namespace Core.Dto
{
    public class NovaPostRequest
    {
        public string apiKey { get; set; }
        public string modelName { get; set; }
        public string calledMethod { get; set; }
        public NovaPostRequestProperties methodProperties { get; set; }
    }
}

