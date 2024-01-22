namespace BlazorServer.Models
{
    public class ResponseModel
    {
    }

    public class BlogListResponseModel
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public List<BlogModel> Data { get; set; }

        public static implicit operator BlogListResponseModel(BlogModel v)
        {
            throw new NotImplementedException();
        }
    }

    public class BlogResponseModel
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public BlogModel Data { get; set; }

    }
}
