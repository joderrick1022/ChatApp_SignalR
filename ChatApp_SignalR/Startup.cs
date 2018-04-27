using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatApp_SignalR.Startup))]
namespace ChatApp_SignalR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
