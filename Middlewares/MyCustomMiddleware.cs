namespace SimleMiddleware.Middlewares
{
    public class MyCustomMiddleware
    {
        private readonly RequestDelegate _next ;

        public MyCustomMiddleware( RequestDelegate next)
        {
            _next =next ;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await context.Response.WriteAsync("    This is my firsty reuseable middleware from MyCustomMiddleware class !    ") ;
            await _next(context) ;
        }
    }



    public static class MuCustomMiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder builder) 
        {
            return builder.UseMiddleware<MyCustomMiddleware>()  ;
        }
    }
}

