using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Helpers.FileHelpers;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Module = Autofac.Module;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder containerBuilder) 
        {
            containerBuilder.RegisterType<CarManager>().As<ICarService>().SingleInstance();
            containerBuilder.RegisterType<EfCarDal>().As<ICarDal>().SingleInstance();
            containerBuilder.RegisterType<CarImageManager>().As<ICarImageService>().SingleInstance();
            containerBuilder.RegisterType<EfCarImageDal>().As<ICarImageDal>().SingleInstance();
            containerBuilder.RegisterType<FileHelperManager>().As<IFileHelper>().SingleInstance();
            containerBuilder.RegisterType<RentalManager>().As<IRentalService>().SingleInstance();
            containerBuilder.RegisterType<EfRentalDal>().As<IRentalDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            containerBuilder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
