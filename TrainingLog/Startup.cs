using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrainingLog.Startup))]
namespace TrainingLog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
