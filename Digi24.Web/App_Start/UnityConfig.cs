using System;
using Unity;
using Unity.Injection;
using Unity.Lifetime;
using Unity.Resolution;
using Digi24.BusinessLogic.Contracts;
using Digi24.BusinessLogic.Services;
using Digi24.Repository.Contracts;
using Digi24.Repository.Infrastructure;
using Digi24.Repository.Repositories;

namespace Digi24.Web
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
            // container.RegisterType<IProductRepository, ProductRepository>();

            RegisterServices(container);
            RegisterRepositories(container);
        }


        private static void RegisterServices(IUnityContainer container)
        {
            container.RegisterType<IExamTypeService, ExamTypeService>();
            container.RegisterType<ISubjectService, SubjectService>();
            container.RegisterType<IStudentService, StudentService>();
            container.RegisterType<IEmployeeService, EmployeeService>();
            container.RegisterType<IEnrolmentService, EnrolmentService>();

        }

        private static void RegisterRepositories(IUnityContainer container)
        {
            container.RegisterType<IDbStore, DbStore>(new SingletonLifetimeManager(), new InjectionConstructor(typeof(string)));
            container.Resolve<IDbStore>(new ResolverOverride[]{
                new ParameterOverride("connectionStringName","SchoolDB")
            });

            container.RegisterType<IAppointmentRepository, AppointmentRepository>();
            container.RegisterType<IAttendanceRepository, AttendanceRepository>();
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
            container.RegisterType<IEnrolmentRepository, EnrolmentRepository>();
            container.RegisterType<IExaminationRepository, ExaminationRepository>();
            container.RegisterType<IExamTimeTableRepository, ExamTimeTableRepository>();
            container.RegisterType<IExamTypeRepository, ExamTypeRepository>();
            container.RegisterType<IFeesPaymentRepository, FeesPaymentRepository>();
            container.RegisterType<IHomeworkRepository, HomeworkRepository>();
            container.RegisterType<ILogRepository, LogRepository>();
            container.RegisterType<IMarksListRepository, MarksListRepository>();
            container.RegisterType<IMarksRepository, MarksRepository>();
            container.RegisterType<INoticesRepository, NoticesRepository>();
            container.RegisterType<IStandardRepository, StandardRepository>();
            container.RegisterType<IStudentRepository, StudentRepository>();
            container.RegisterType<ISubjectRepository, SubjectRepository>();
            container.RegisterType<ITimetableRepository, TimetableRepository>();
        }
    }
}