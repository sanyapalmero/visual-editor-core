using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CoreEditor.Migrations
{
    public partial class AddAdvTypeForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdvTypeId",
                table: "Orders",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AdvTypeId",
                table: "Orders",
                column: "AdvTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AdvTypes_AdvTypeId",
                table: "Orders",
                column: "AdvTypeId",
                principalTable: "AdvTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AdvTypes_AdvTypeId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_AdvTypeId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AdvTypeId",
                table: "Orders");
        }
    }
}
