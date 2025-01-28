using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp2.Migrations
{
    /// <inheritdoc />
    public partial class AddCreatedAtFieldToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "ADMPAY_CUSTOMER");

            migrationBuilder.RenameColumn(
                name: "adus_code",
                table: "ADMPAY_CUSTOMER",
                newName: "ADUS_CODE");

            migrationBuilder.RenameColumn(
                name: "adcu_phone",
                table: "ADMPAY_CUSTOMER",
                newName: "ADCU_PHONE");

            migrationBuilder.RenameColumn(
                name: "adcu_observation",
                table: "ADMPAY_CUSTOMER",
                newName: "ADCU_OBSERVATION");

            migrationBuilder.RenameColumn(
                name: "adcu_nationalid",
                table: "ADMPAY_CUSTOMER",
                newName: "ADCU_NATIONALID");

            migrationBuilder.RenameColumn(
                name: "adcu_name",
                table: "ADMPAY_CUSTOMER",
                newName: "ADCU_NAME");

            migrationBuilder.RenameColumn(
                name: "adcu_email",
                table: "ADMPAY_CUSTOMER",
                newName: "ADCU_EMAIL");

            migrationBuilder.RenameColumn(
                name: "adcu_direction",
                table: "ADMPAY_CUSTOMER",
                newName: "ADCU_DIRECTION");

            migrationBuilder.RenameColumn(
                name: "adcu_dateupdate",
                table: "ADMPAY_CUSTOMER",
                newName: "ADCU_DATEUPDATE");

            migrationBuilder.RenameColumn(
                name: "adcu_datecreated",
                table: "ADMPAY_CUSTOMER",
                newName: "ADCU_DATECREATED");

            migrationBuilder.RenameColumn(
                name: "adcu_coordinates",
                table: "ADMPAY_CUSTOMER",
                newName: "ADCU_COORDINATES");

            migrationBuilder.RenameColumn(
                name: "adbu_code",
                table: "ADMPAY_CUSTOMER",
                newName: "ADBU_CODE");

            migrationBuilder.RenameColumn(
                name: "adcu_code",
                table: "ADMPAY_CUSTOMER",
                newName: "ADCU_CODE");

            migrationBuilder.AlterColumn<string>(
                name: "ADUS_CODE",
                table: "ADMPAY_CUSTOMER",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ADCU_PHONE",
                table: "ADMPAY_CUSTOMER",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ADCU_OBSERVATION",
                table: "ADMPAY_CUSTOMER",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ADCU_NATIONALID",
                table: "ADMPAY_CUSTOMER",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ADCU_NAME",
                table: "ADMPAY_CUSTOMER",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ADCU_EMAIL",
                table: "ADMPAY_CUSTOMER",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ADCU_DIRECTION",
                table: "ADMPAY_CUSTOMER",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ADCU_DATEUPDATE",
                table: "ADMPAY_CUSTOMER",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ADCU_DATECREATED",
                table: "ADMPAY_CUSTOMER",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "ADCU_COORDINATES",
                table: "ADMPAY_CUSTOMER",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "ADCU_ESTADO",
                table: "ADMPAY_CUSTOMER",
                type: "bit",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ADMPAY_CUSTOMER",
                table: "ADMPAY_CUSTOMER",
                column: "ADCU_CODE");

            migrationBuilder.CreateTable(
                name: "ADMPAY_BUSINESS",
                columns: table => new
                {
                    ADBU_CODE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADBU_RUC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADBU_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADBU_COMPANYNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADBU_DIRECTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADBU_EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADBU_PAGE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADBU_MANAGER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADBU_USERUPDATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADBU_DATECREATED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ADBU_DATEUPDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ADBU_LOGO = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADMPAY_BUSINESS", x => x.ADBU_CODE);
                });

            migrationBuilder.CreateTable(
                name: "ADMPAY_DATAILTRX",
                columns: table => new
                {
                    ADAT_CODE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADBU_CODE = table.Column<int>(type: "int", nullable: false),
                    ADAT_PERIODOPAGO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADAT_TIPOPAGO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADCU_CODE = table.Column<int>(type: "int", nullable: true),
                    ADAT_COMPROBANTE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADAT_DESCRIPCION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADUS_CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADAT_DATECREATED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ADAT_DATEUPDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ADAT_VALOR = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADMPAY_DATAILTRX", x => x.ADAT_CODE);
                });

            migrationBuilder.CreateTable(
                name: "viewerPagos",
                columns: table => new
                {
                    clienteName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trxDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    anio = table.Column<int>(type: "int", nullable: true),
                    periodo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    comprobante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    valor = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ADMPAY_BUSINESS");

            migrationBuilder.DropTable(
                name: "ADMPAY_DATAILTRX");

            migrationBuilder.DropTable(
                name: "viewerPagos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ADMPAY_CUSTOMER",
                table: "ADMPAY_CUSTOMER");

            migrationBuilder.DropColumn(
                name: "ADCU_ESTADO",
                table: "ADMPAY_CUSTOMER");

            migrationBuilder.RenameTable(
                name: "ADMPAY_CUSTOMER",
                newName: "Clientes");

            migrationBuilder.RenameColumn(
                name: "ADUS_CODE",
                table: "Clientes",
                newName: "adus_code");

            migrationBuilder.RenameColumn(
                name: "ADCU_PHONE",
                table: "Clientes",
                newName: "adcu_phone");

            migrationBuilder.RenameColumn(
                name: "ADCU_OBSERVATION",
                table: "Clientes",
                newName: "adcu_observation");

            migrationBuilder.RenameColumn(
                name: "ADCU_NATIONALID",
                table: "Clientes",
                newName: "adcu_nationalid");

            migrationBuilder.RenameColumn(
                name: "ADCU_NAME",
                table: "Clientes",
                newName: "adcu_name");

            migrationBuilder.RenameColumn(
                name: "ADCU_EMAIL",
                table: "Clientes",
                newName: "adcu_email");

            migrationBuilder.RenameColumn(
                name: "ADCU_DIRECTION",
                table: "Clientes",
                newName: "adcu_direction");

            migrationBuilder.RenameColumn(
                name: "ADCU_DATEUPDATE",
                table: "Clientes",
                newName: "adcu_dateupdate");

            migrationBuilder.RenameColumn(
                name: "ADCU_DATECREATED",
                table: "Clientes",
                newName: "adcu_datecreated");

            migrationBuilder.RenameColumn(
                name: "ADCU_COORDINATES",
                table: "Clientes",
                newName: "adcu_coordinates");

            migrationBuilder.RenameColumn(
                name: "ADBU_CODE",
                table: "Clientes",
                newName: "adbu_code");

            migrationBuilder.RenameColumn(
                name: "ADCU_CODE",
                table: "Clientes",
                newName: "adcu_code");

            migrationBuilder.AlterColumn<string>(
                name: "adus_code",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "adcu_phone",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "adcu_observation",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "adcu_nationalid",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "adcu_name",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "adcu_email",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "adcu_direction",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "adcu_dateupdate",
                table: "Clientes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "adcu_datecreated",
                table: "Clientes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "adcu_coordinates",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "adcu_code");
        }
    }
}
