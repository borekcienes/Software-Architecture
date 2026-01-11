public static class ProductEndpoints
{
    public static void MapProductEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/products", GetAll);
        app.MapGet("/products/{id}", GetById);
        app.MapPost("/products", Create);
        app.MapPut("/products/{id}", Update);
        app.MapDelete("/products/{id}", Delete);
    }
}
