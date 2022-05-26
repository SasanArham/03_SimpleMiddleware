using SimleMiddleware.Middlewares;

var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();



app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("first inline middleware fired !     ");
    await next(context);
});


app.UseCustomMiddleware();


app.Run(async (context) =>
{
    await context.Response.WriteAsync("hey !  this is Second inline middleware wich shoul execute at last !");
}
);


app.Run();
