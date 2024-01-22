using BlazorServer.Models;

namespace BlazorServer.Data
{
    public class BlogService
    {
        public List<BlogModel> BlogList = new List<BlogModel>();

        public void AddBlog(BlogModel blog)
        {
            BlogList.Add(blog);
        }
    }
}
