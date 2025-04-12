﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YumBlazor.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatingModelOrderHeader : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "OrderHeaders",
                newName: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "OrderHeaders",
                newName: "MyProperty");
        }
    }
}
