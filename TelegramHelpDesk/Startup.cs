using Microsoft.Owin;
using Owin;
[assembly: OwinStartup(typeof(TelegramHelpDesk.Startup))]

namespace TelegramHelpDesk
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
