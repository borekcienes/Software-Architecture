using Microsoft.AspNetCore.Authorization;

public static class OrderEndpoints
{
    public static void MapOrderEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapPost("/orders", CreateOrder).RequireAuthorization();
        app.MapGet("/orders", GetAllOrders).RequireAuthorization("Admin");
        app.MapGet("/orders/{id}", GetOrderById).RequireAuthorization();
    }
