using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CoreEditor.Migrations
{
    public partial class AddMaterialForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaterialId",
                table: "Orders",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_MaterialId",
                table: "Orders",
                column: "MaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Material_MaterialId",
                table: "Orders",
                column: "MaterialId",
                principalTable: "Material",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Material_MaterialId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_MaterialId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "MaterialId",
                table: "Orders");
        }
    }
}
