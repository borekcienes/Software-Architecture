using Microsoft.AspNetCore.Authorization;

public static class UserEndpoints
{
    public static void MapUserEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapPost("/users", CreateUser);
        app.MapGet("/users", GetAllUsers).RequireAuthorization("Admin");
        app.MapGet("/users/{id}", GetUserById);
        app.MapPut("/users/{id}", UpdateUser);
        app.MapDelete("/users/{id}", DeleteUser);

        app.MapPost("/auth/login", Login);
    }
