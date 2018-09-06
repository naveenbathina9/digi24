
namespace Digi24.API
{
    using Repository.Infrastructure;
    using Repository.Repositories;
    using Repository.Contracts;

    public class Bootstrapper
    {
        private static IBindingRoot binder;
        public static void Bootstrap(IBindingRoot bindingRoot)
        {
            binder = bindingRoot;
            RegisterRepositories();
            RegisterServices();
        }

        private static void RegisterServices()
        {
            //binder.Bind<IDocumentService>().To<DocumentsServices>();
            //binder.Bind<INoteService>().To<NoteServices>();
            //binder.Bind<ISmartFileService>().To<SmartFileService>();
            //binder.Bind<ILoggingUtility>().To<LoggingUtility>();
            //binder.Bind<IGaloreCoreService>().To<GaloreCoreService>();
            //binder.Bind<ITemplateService>().To<TemplateService>();
            //// binder.Bind<ILoggerFacade>().To<NLogFacade>();
            //binder.Bind<IUserService>().To<UserService>();
            //binder.Bind<IFieldAuthorizationService>().To<FieldAuthorizationService>();
            //binder.Bind<IPrincipal>().ToMethod(context => HttpContext.Current.User).InTransientScope();
        }

        private static void RegisterRepositories()
        {
            binder.Bind<IExamTypeRepository>().To<ExamTypeRepository>();
            //binder.Bind<INotesRepository>().To<NotesRepository>();
            //binder.Bind<ISmartFileRepository>().To<SmartFileRepository>();
            //binder.Bind<ITemplateRepository>().To<TemplateRepository>();

            //binder.Bind<ICoreEmailHelper>().To<CoreEmailHelper>();
            //binder.Bind<ICoreUtilityMethod>().To<CoreUtilityMethod>();

            binder.Bind<IDbStore>().To<DbStore>().WithConstructorArgument("connectionStringName", "SchoolDB");
        }
    }
}