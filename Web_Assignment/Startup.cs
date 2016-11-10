using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_Assignment.Startup))]
namespace Web_Assignment
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
