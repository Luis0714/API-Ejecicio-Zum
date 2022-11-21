using Autofac;
using Autofac.Integration.WebApi;
using Microsoft.Owin;
using Microsoft.Owin.Builder;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApiEjercicio.Config;

[assembly:OwinStartup(typeof(WebApiEjercicio.Startup))]

namespace WebApiEjercicio
{
    public class Startup
    {
        public static IContainer container { set; get; }

        public void configuration(AppBuilder app)
        {
            var builder = new ContainerBuilder();

            HttpConfiguration config = new HttpConfiguration();

            //registrar api controllers en la ejecucion asembly
            builder.RegisterApiControllers(typeof(Startup).Assembly);
            //Register your Web API controllers.  
          

            builder.RegisterWebApiFilterProvider(config);

            builder.addServices();
            container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            GlobalConfiguration.Configuration.DependencyResolver = config.DependencyResolver;

            app.UseAutofacMiddleware(container);


            app.UseAutofacWebApi(config);
            app.UseWebApi(config);
        }
    }
}