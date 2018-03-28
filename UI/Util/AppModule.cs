using BLL.Interfaces;
using BLL.Services;
using Ninject.Modules;

namespace UI.Util
{
    public class AppModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IAppService>().To<AppService>();
        }
    }
}