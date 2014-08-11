using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InterviewQ.MVC.Startup))]
namespace InterviewQ.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
