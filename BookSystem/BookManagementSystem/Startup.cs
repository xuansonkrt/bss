using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookManagementSystem.Startup))]
namespace BookManagementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
