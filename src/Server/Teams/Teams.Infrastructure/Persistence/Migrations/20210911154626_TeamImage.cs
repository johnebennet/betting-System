﻿namespace BettingSystem.Infrastructure.Teams.Persistence.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class TeamImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image_Original",
                table: "Teams",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "Image_Thumbnail",
                table: "Teams",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image_Original",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Image_Thumbnail",
                table: "Teams");
        }
    }
}
