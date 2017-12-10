using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatApplication.Server.Startup))]
namespace ChatApplication.Server
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
