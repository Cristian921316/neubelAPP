using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    adcu_code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adbu_code = table.Column<int>(type: "int", nullable: false),
                    adcu_nationalid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adcu_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adcu_phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adcu_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adcu_direction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adcu_coordinates = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adcu_observation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adus_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adcu_datecreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    adcu_dateupdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.adcu_code);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
