using BlazorServer.Data;
using BlazorServer.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorServer.Pages
{
    public partial class Blog
    {
        [Inject] 
        private ClientService clientService { get; set; }

        private List<BlogModel> BlogList = new List<BlogModel>();
        private bool Error;
        private bool shouldRender;

        protected override bool ShouldRender() => shouldRender;

        protected override async Task OnInitializedAsync()
        {
           // await Task.Delay(5000);

            BlogListResponseModel model = await clientService.GetAsync<BlogListResponseModel>("https://localhost:7001/api/Blog");
            BlogList = model.Data;

            if (model is null)
            {
                Error = true;
            }

            shouldRender = true;
        }

    }
}
