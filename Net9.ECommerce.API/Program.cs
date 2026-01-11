//Service Registration
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();


//JWT Authentication
builder.Services.AddAuthentication(...)
    .AddJwtBearer(...);


//Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Middleware Tanımları
app.UseMiddleware<ExceptionMiddleware>();
app.UseAuthentication();
app.UseAuthorization();


//Endpoint Map’leri
app.MapProductEndpoints();
app.MapUserEndpoints();
app.MapOrderEndpoints();