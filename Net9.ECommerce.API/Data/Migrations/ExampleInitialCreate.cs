
//dotnet ef migrations add InitialCreate
//dotnet ef database update
//Bu komutlardan sonra migration otomatik olarak oluşturulur

/*public partial class InitialCreate : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Users",
            columns: table => new
            {
                Id = table.Column<int>(),
                Username = table.Column<string>(),
                PasswordHash = table.Column<string>(),
                Role = table.Column<string>(),
                CreatedAt = table.Column<DateTime>(),
                UpdatedAt = table.Column<DateTime>(),
                IsDeleted = table.Column<bool>()
            });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable("Users");
    }
}*/
