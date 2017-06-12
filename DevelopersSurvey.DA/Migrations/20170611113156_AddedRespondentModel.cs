namespace DevelopersSurvey.DA.Migrations
{
    using Microsoft.EntityFrameworkCore.Metadata;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddedRespondentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateTable(
                name: "Experiances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Respondents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    Age = table.Column<byte>(nullable: true),
                    CurrentPosition = table.Column<string>(nullable: true),
                    Databases = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    Frameworks = table.Column<string>(nullable: true),
                    IsCurrentlyEmployed = table.Column<bool>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    OtherInfo = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PlaceOfStudying = table.Column<string>(nullable: true),
                    ProgrammingLanguages = table.Column<string>(nullable: true),
                    Skype = table.Column<string>(nullable: true),
                    SpecialCources = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Respondents", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Experiances");

            migrationBuilder.DropTable(
                name: "Respondents");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");
        }
    }
}
