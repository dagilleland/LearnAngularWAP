using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngWebForm.Startup))]
namespace AngWebForm
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
