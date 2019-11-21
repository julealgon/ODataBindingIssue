using julealgon.ODataBindingIssues.Entities;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OData.Edm;

namespace julealgon.ODataBindingIssues
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOData();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseOData(GetEdmModel());
        }

        private IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<Entity>("Entities");

            return builder.GetEdmModel();
        }
    }
}
