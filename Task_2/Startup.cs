using Microsoft.AspNetCore.Builder;

namespace Task_2
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // AddMvc - добавляет сервисы, необходимые для работы MVC, включая Razor-страницы
            // services.AddMvc();

            // AddControllersWithViews - добавляет сервисы, необходимые для работы MVC, 
            // не включая Razor-страницы - только контроллеры и представления.
            // Для примеров данного курса этого достаточно.
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                        name: "Default",
                        pattern: "{controller=Home}/{action=Index}/{*data}"
                    );
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //            name: "ProductsList",
            //            pattern: "{controller=Products}/{action=List}/{data?}"
            //        );
            //});

        }
    }
}
