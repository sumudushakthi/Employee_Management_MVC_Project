﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class SystemProfiles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SystemProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfileId = table.Column<int>(type: "int", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: true),
                    CreateByID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemProfiles_SystemProfiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "SystemProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SystemProfiles_ProfileId",
                table: "SystemProfiles",
                column: "ProfileId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SystemProfiles");
        }
    }
}
