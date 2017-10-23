using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Suggestion_Box.Startup))]
namespace Suggestion_Box
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
