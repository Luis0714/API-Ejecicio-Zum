using Autofac;
using Autofac.Integration.WebApi;
using BC_Entities;
using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using System.Web.Http;

[assembly: OwinStartup(typeof(WebApiEjercicio.Startup))]

namespace WebApiEjercicio
{
    public class Startup
    {
        public static IContainer container { set; get; }
        public void Configuration(IAppBuilder app)
        {
            // Para obtener más información sobre cómo configurar la aplicación, visite https://go.microsoft.com/fwlink/?LinkID=316888
            var builder = new ContainerBuilder();
            HttpConfiguration config = new HttpConfiguration();
            // Register Web API controller in executing assembly.

            builder.RegisterApiControllers(typeof(Startup).Assembly);
            builder.RegisterWebApiFilterProvider(config);

            //Registrar dependencias
            builder.RegisterType<Computer>();

            //Construir el contenedor
            container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = config.DependencyResolver;
            app.UseAutofacMiddleware(container);
            app.UseAutofacWebApi(config);
            app.UseWebApi(config);
        }
    }
}
