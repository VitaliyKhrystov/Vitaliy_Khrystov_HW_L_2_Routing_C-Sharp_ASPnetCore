namespace Task_1
{
    public class Program
    {

        //Задание 1 (Additional Task)
        //Создайте веб приложение, которое будет обрабатывать следующие запросы: 
        //Calc/Add/20/20 выполняет сложение и возвращает значение 30; 
        //Calc/Mul/20/10 выполняет умножение и возвращает значение 200; 
        //Calc/Div/20/10 выполняет сложение и возвращает значение 2;
        //Calc/Sub/20/10 выполняет вычитание и возвращает значение 10.


        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Calc}/{action=Add}/{value1?}/{value2?}");

            app.Run();
        }
    }
}