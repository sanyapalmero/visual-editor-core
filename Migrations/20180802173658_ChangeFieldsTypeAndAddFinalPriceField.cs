using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CoreEditor.Migrations
{
    public partial class ChangeFieldsTypeAndAddFinalPriceField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FinalPrice",
                table: "Orders",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaterialPrice",
                table: "Material",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TypePrice",
                table: "AdvTypes",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinalPrice",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "MaterialPrice",
                table: "Material",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TypePrice",
                table: "AdvTypes",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
