using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Globalization;

namespace Given_Brittany_HW1
{
    public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        //NOTE: This adds the MVC engine and Razor code
        services.AddControllersWithViews();
    }

    public void Configure(IApplicationBuilder app)
    {
        //These lines allow you to see more detailed error messages
        app.UseDeveloperExceptionPage();
        app.UseStatusCodePages();

        //This line allows you to use static pages like style sheets and images
        app.UseStaticFiles();

        //This marks the position in the middleware pipeline where a routing decision
        //is made for a URL.
        app.UseRouting();

        //This allows the data annotations for currency to work on Macs
        app.Use(async (context, next) =>
        {
            CultureInfo.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            CultureInfo.CurrentUICulture = CultureInfo.CurrentCulture;

            await next.Invoke();
        });

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}
}