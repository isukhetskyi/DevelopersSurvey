using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DevelopersSurvey.DA.Migrations
{
    public partial class AddedExperiance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "ProgrammingLanguages");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Frameworks");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Databases");

            migrationBuilder.AddColumn<int>(
                name: "ExperianceId",
                table: "ProgrammingLanguages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExperianceId",
                table: "Frameworks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExperianceId",
                table: "Databases",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Experiances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiances", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProgrammingLanguages_ExperianceId",
                table: "ProgrammingLanguages",
                column: "ExperianceId");

            migrationBuilder.CreateIndex(
                name: "IX_Frameworks_ExperianceId",
                table: "Frameworks",
                column: "ExperianceId");

            migrationBuilder.CreateIndex(
                name: "IX_Databases_ExperianceId",
                table: "Databases",
                column: "ExperianceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Databases_Experiances_ExperianceId",
                table: "Databases",
                column: "ExperianceId",
                principalTable: "Experiances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Frameworks_Experiances_ExperianceId",
                table: "Frameworks",
                column: "ExperianceId",
                principalTable: "Experiances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProgrammingLanguages_Experiances_ExperianceId",
                table: "ProgrammingLanguages",
                column: "ExperianceId",
                principalTable: "Experiances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Databases_Experiances_ExperianceId",
                table: "Databases");

            migrationBuilder.DropForeignKey(
                name: "FK_Frameworks_Experiances_ExperianceId",
                table: "Frameworks");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgrammingLanguages_Experiances_ExperianceId",
                table: "ProgrammingLanguages");

            migrationBuilder.DropTable(
                name: "Experiances");

            migrationBuilder.DropIndex(
                name: "IX_ProgrammingLanguages_ExperianceId",
                table: "ProgrammingLanguages");

            migrationBuilder.DropIndex(
                name: "IX_Frameworks_ExperianceId",
                table: "Frameworks");

            migrationBuilder.DropIndex(
                name: "IX_Databases_ExperianceId",
                table: "Databases");

            migrationBuilder.DropColumn(
                name: "ExperianceId",
                table: "ProgrammingLanguages");

            migrationBuilder.DropColumn(
                name: "ExperianceId",
                table: "Frameworks");

            migrationBuilder.DropColumn(
                name: "ExperianceId",
                table: "Databases");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ProgrammingLanguages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Frameworks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Databases",
                nullable: true);
        }
    }
}
