using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Electronic_store.Startup))]
namespace Electronic_store
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
