namespace middleware2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.UseWelcomePage("/welcome");

            //app.Use(async (context, next) =>
            //{
            //    Console.WriteLine(context.Request.Headers["User-Agent"]);
            //    await next.Invoke();
            //});

            app.UseMiddleware<Middleware>();

            app.Run();
        }
    }
}