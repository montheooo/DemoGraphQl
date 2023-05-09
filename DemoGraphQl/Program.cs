namespace DemoGraphQl
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

           // builder.Services.AddGraphQLServer().AddQueryType<Query1>().AllowIntrospection(true);
            builder.Services.AddGraphQLServer().AddQueryType<Query1>();

            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.MapGraphQL();

            app.Run();
        }
    }
}