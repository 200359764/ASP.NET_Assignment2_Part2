using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SeunghwanKim_ASP.NET_Assignment2_Part1.Startup))]
namespace SeunghwanKim_ASP.NET_Assignment2_Part1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
