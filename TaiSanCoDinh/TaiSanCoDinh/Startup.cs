using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TaiSanCoDinh.Startup))]
namespace TaiSanCoDinh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
