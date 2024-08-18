using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CowManager>().As<ICowService>();
            builder.RegisterType<EfCowDal>().As<ICowDal>();

            builder.RegisterType<IllnessManager>().As<IIllnessService>();
            builder.RegisterType<EfIlnessDal>().As<IIllnessDal>();

            builder.RegisterType<VaccineManager>().As<IVaccineService>();
            builder.RegisterType<EfVaccineDal>().As<IVaccineDal>();

            builder.RegisterType<MedicineManager>().As<IMedicineService>();
            builder.RegisterType<EfMedicineDal>().As<IMedicineDal>();

            builder.RegisterType<CowIllnessManager>().As<ICowIllnessService>();
            builder.RegisterType<EfCowIllnessDal>().As<ICowIllnessDal>();

            builder.RegisterType<CowVaccineManager>().As<ICowVaccineService>();
            builder.RegisterType<EfCowVaccineDal>().As<ICowVaccineDal>();

            builder.RegisterType<CowMedicineManager>().As<ICowMedicineService>();
            builder.RegisterType<EfCowMedicineDal>().As<ICowMedicineDal>();

            builder.RegisterType<CowEstrusPeriodManager>().As<ICowEstrusPeriodService>();
            builder.RegisterType<EfCowEstrusPeriodDal>().As<ICowEstrusPeriodDal>();


        }
    }
}
