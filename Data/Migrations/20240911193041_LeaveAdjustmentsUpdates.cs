using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class LeaveAdjustmentsUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CModifiedOn",
                table: "LeaveAdjustmentEntries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreateByID",
                table: "LeaveAdjustmentEntries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateOn",
                table: "LeaveAdjustmentEntries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByID",
                table: "LeaveAdjustmentEntries",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CModifiedOn",
                table: "LeaveAdjustmentEntries");

            migrationBuilder.DropColumn(
                name: "CreateByID",
                table: "LeaveAdjustmentEntries");

            migrationBuilder.DropColumn(
                name: "CreateOn",
                table: "LeaveAdjustmentEntries");

            migrationBuilder.DropColumn(
                name: "ModifiedByID",
                table: "LeaveAdjustmentEntries");
        }
    }
}
