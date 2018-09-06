using Digi24.API.App_Start;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject;
using Ninject.Web.Common;
using Ninject.Web.Common.WebHost;
using System;
using System.Web;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(NinjectWebCommon), "Stop")]
namespace Digi24.API.App_Start
{
    using Digi24.BusinessLogic.Contracts;
    using Digi24.BusinessLogic.Services;
    using Digi24.Repository.Contracts;
    using Digi24.Repository.Infrastructure;
    using Digi24.Repository.Repositories;

    public class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

            RegisterServices(kernel);
            RegisterRepositories(kernel);
            return kernel;
        }

        private static void RegisterRepositories(IKernel kernel)
        {
            kernel.Bind<IDbStore>().To<DbStore>().WithConstructorArgument("connectionStringName", "SchoolDB");
            kernel.Bind<IExamTypeRepository>().To<ExamTypeRepository>();
            kernel.Bind<ISubjectRepository>().To<SubjectRepository>();
        }

        private static void RegisterServices(IKernel kernel)
        {
            //kernel.Bind<IRepo>().ToMethod(ctx => new Repo("Ninject Rocks!"));
            kernel.Bind<IExamTypeService>().To<ExamTypeService>();
            kernel.Bind<ISubjectService>().To<SubjectService>();
        }
    }
}