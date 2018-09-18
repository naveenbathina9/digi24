using Digi24.BusinessLogic.Contracts;
using Digi24.BusinessLogic.Services;
using Digi24.Repository.Contracts;
using Digi24.Repository.Infrastructure;
using Digi24.Repository.Repositories;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using Unity;
using Unity.Exceptions;
using Unity.Injection;
using Unity.Lifetime;
using Unity.Resolution;

namespace Digi24.API.App_Start
{
    public class UnityResolver : IDependencyResolver
    {
        protected IUnityContainer container;

        public UnityResolver(IUnityContainer container)
        {
            if (container == null)
            {
                throw new ArgumentNullException("container");
            }
            this.container = container;
            RegisterRepositories();
            RegisterServices();
        }


        private void RegisterServices()
        {
            container.RegisterType<IExamTypeService, ExamTypeService>();
            container.RegisterType<ISubjectService, SubjectService>();
            container.RegisterType<IStudentService, StudentService>();
            container.RegisterType<IEmployeeService, EmployeeService>();
            container.RegisterType<IEnrolmentService, EnrolmentService>();
            container.RegisterType<IMarksService, MarksService>();
            container.RegisterType<IAppointmentService, AppointmentService>();
            container.RegisterType<IHomeworkService, HomeworkService>();

        }

        private void RegisterRepositories()
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

        public object GetService(Type serviceType)
        {
            try
            {
                return container.Resolve(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return container.ResolveAll(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return new List<object>();
            }
        }

        public IDependencyScope BeginScope()
        {
            var child = container.CreateChildContainer();
            return new UnityResolver(child);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            container.Dispose();
        }
    }
}