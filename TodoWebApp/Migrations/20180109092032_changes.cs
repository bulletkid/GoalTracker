using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TodoWebApp.Migrations
{
    public partial class changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Todo");

            migrationBuilder.AlterColumn<string>(
                name: "Goal",
                table: "Todo",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Todo",
                maxLength: 45,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ExecutedSessions",
                table: "Todo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "PercentageAccomplished",
                table: "Todo",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "PlannedSessions",
                table: "Todo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Points",
                table: "Todo",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "Todo",
                maxLength: 45,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "ExecutedSessions",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "PercentageAccomplished",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "PlannedSessions",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "Points",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "Subject",
                table: "Todo");

            migrationBuilder.AlterColumn<string>(
                name: "Goal",
                table: "Todo",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Todo",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Todo",
                nullable: true);
        }
    }
}
