using Autofac;
using B_Interfacese;
using B_Services;
using BC_DataAcessLayer;
using BC_Entities;
using Bussines_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiEjercicio.Config
{
    public static class ConfigServices
    {
        public static ContainerBuilder addServices(this ContainerBuilder builder)
        {
            builder.RegisterType<EmailSender>().As<IMessageSender>().InstancePerRequest();
            builder.RegisterType<TextMessageSender>().As<IMessageSender>().InstancePerRequest();
            builder.RegisterType<Phone>().InstancePerRequest();
            builder.RegisterType<PhoneDAL>().InstancePerRequest();
            builder.RegisterType<PhoneBL>().InstancePerRequest();
            return builder;
        }
    }

}