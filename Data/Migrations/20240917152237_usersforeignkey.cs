﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class usersforeignkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByID",
                table: "SystemProfiles",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "SystemProfiles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByID",
                table: "SystemCodeDetails",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "SystemCodeDetails",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByID",
                table: "SystemCode",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "SystemCode",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByID",
                table: "LeaveTypes",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "LeaveTypes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByID",
                table: "LeavePeriods",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "LeavePeriods",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByID",
                table: "LeaveApplications",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedByID",
                table: "LeaveApplications",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "LeaveApplications",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByID",
                table: "LeaveAdjustmentEntries",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "LeaveAdjustmentEntries",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByID",
                table: "Holidays",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Holidays",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByID",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByID",
                table: "Designations",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Designations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByID",
                table: "Departments",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Departments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByID",
                table: "Countries",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Countries",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByID",
                table: "Bank",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Bank",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByID",
                table: "ApprovalsUserMatrixs",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "ApprovalsUserMatrixs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SystemProfiles_CreatedById",
                table: "SystemProfiles",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_SystemProfiles_ModifiedByID",
                table: "SystemProfiles",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_SystemCodeDetails_CreatedById",
                table: "SystemCodeDetails",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_SystemCodeDetails_ModifiedByID",
                table: "SystemCodeDetails",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_SystemCode_CreatedById",
                table: "SystemCode",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_SystemCode_ModifiedByID",
                table: "SystemCode",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveTypes_CreatedById",
                table: "LeaveTypes",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveTypes_ModifiedByID",
                table: "LeaveTypes",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_LeavePeriods_CreatedById",
                table: "LeavePeriods",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_LeavePeriods_ModifiedByID",
                table: "LeavePeriods",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveApplications_ApprovedByID",
                table: "LeaveApplications",
                column: "ApprovedByID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveApplications_CreatedById",
                table: "LeaveApplications",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveApplications_ModifiedByID",
                table: "LeaveApplications",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveAdjustmentEntries_CreatedById",
                table: "LeaveAdjustmentEntries",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveAdjustmentEntries_ModifiedByID",
                table: "LeaveAdjustmentEntries",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Holidays_CreatedById",
                table: "Holidays",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Holidays_ModifiedByID",
                table: "Holidays",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CreatedById",
                table: "Employees",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ModifiedByID",
                table: "Employees",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Designations_CreatedById",
                table: "Designations",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Designations_ModifiedByID",
                table: "Designations",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_CreatedById",
                table: "Departments",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ModifiedByID",
                table: "Departments",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CreatedById",
                table: "Countries",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_ModifiedByID",
                table: "Countries",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Bank_CreatedById",
                table: "Bank",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Bank_ModifiedByID",
                table: "Bank",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_ApprovalsUserMatrixs_CreatedById",
                table: "ApprovalsUserMatrixs",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ApprovalsUserMatrixs_ModifiedByID",
                table: "ApprovalsUserMatrixs",
                column: "ModifiedByID");

            migrationBuilder.AddForeignKey(
                name: "FK_ApprovalsUserMatrixs_AspNetUsers_CreatedById",
                table: "ApprovalsUserMatrixs",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApprovalsUserMatrixs_AspNetUsers_ModifiedByID",
                table: "ApprovalsUserMatrixs",
                column: "ModifiedByID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bank_AspNetUsers_CreatedById",
                table: "Bank",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bank_AspNetUsers_ModifiedByID",
                table: "Bank",
                column: "ModifiedByID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_AspNetUsers_CreatedById",
                table: "Countries",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_AspNetUsers_ModifiedByID",
                table: "Countries",
                column: "ModifiedByID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_AspNetUsers_CreatedById",
                table: "Departments",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_AspNetUsers_ModifiedByID",
                table: "Departments",
                column: "ModifiedByID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Designations_AspNetUsers_CreatedById",
                table: "Designations",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Designations_AspNetUsers_ModifiedByID",
                table: "Designations",
                column: "ModifiedByID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_AspNetUsers_CreatedById",
                table: "Employees",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_AspNetUsers_ModifiedByID",
                table: "Employees",
                column: "ModifiedByID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Holidays_AspNetUsers_CreatedById",
                table: "Holidays",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Holidays_AspNetUsers_ModifiedByID",
                table: "Holidays",
                column: "ModifiedByID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAdjustmentEntries_AspNetUsers_CreatedById",
                table: "LeaveAdjustmentEntries",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAdjustmentEntries_AspNetUsers_ModifiedByID",
                table: "LeaveAdjustmentEntries",
                column: "ModifiedByID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveApplications_AspNetUsers_ApprovedByID",
                table: "LeaveApplications",
                column: "ApprovedByID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveApplications_AspNetUsers_CreatedById",
                table: "LeaveApplications",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveApplications_AspNetUsers_ModifiedByID",
                table: "LeaveApplications",
                column: "ModifiedByID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LeavePeriods_AspNetUsers_CreatedById",
                table: "LeavePeriods",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LeavePeriods_AspNetUsers_ModifiedByID",
                table: "LeavePeriods",
                column: "ModifiedByID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveTypes_AspNetUsers_CreatedById",
                table: "LeaveTypes",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveTypes_AspNetUsers_ModifiedByID",
                table: "LeaveTypes",
                column: "ModifiedByID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SystemCode_AspNetUsers_CreatedById",
                table: "SystemCode",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SystemCode_AspNetUsers_ModifiedByID",
                table: "SystemCode",
                column: "ModifiedByID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SystemCodeDetails_AspNetUsers_CreatedById",
                table: "SystemCodeDetails",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SystemCodeDetails_AspNetUsers_ModifiedByID",
                table: "SystemCodeDetails",
                column: "ModifiedByID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SystemProfiles_AspNetUsers_CreatedById",
                table: "SystemProfiles",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SystemProfiles_AspNetUsers_ModifiedByID",
                table: "SystemProfiles",
                column: "ModifiedByID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApprovalsUserMatrixs_AspNetUsers_CreatedById",
                table: "ApprovalsUserMatrixs");

            migrationBuilder.DropForeignKey(
                name: "FK_ApprovalsUserMatrixs_AspNetUsers_ModifiedByID",
                table: "ApprovalsUserMatrixs");

            migrationBuilder.DropForeignKey(
                name: "FK_Bank_AspNetUsers_CreatedById",
                table: "Bank");

            migrationBuilder.DropForeignKey(
                name: "FK_Bank_AspNetUsers_ModifiedByID",
                table: "Bank");

            migrationBuilder.DropForeignKey(
                name: "FK_Countries_AspNetUsers_CreatedById",
                table: "Countries");

            migrationBuilder.DropForeignKey(
                name: "FK_Countries_AspNetUsers_ModifiedByID",
                table: "Countries");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_AspNetUsers_CreatedById",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_AspNetUsers_ModifiedByID",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Designations_AspNetUsers_CreatedById",
                table: "Designations");

            migrationBuilder.DropForeignKey(
                name: "FK_Designations_AspNetUsers_ModifiedByID",
                table: "Designations");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_AspNetUsers_CreatedById",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_AspNetUsers_ModifiedByID",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Holidays_AspNetUsers_CreatedById",
                table: "Holidays");

            migrationBuilder.DropForeignKey(
                name: "FK_Holidays_AspNetUsers_ModifiedByID",
                table: "Holidays");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAdjustmentEntries_AspNetUsers_CreatedById",
                table: "LeaveAdjustmentEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAdjustmentEntries_AspNetUsers_ModifiedByID",
                table: "LeaveAdjustmentEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveApplications_AspNetUsers_ApprovedByID",
                table: "LeaveApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveApplications_AspNetUsers_CreatedById",
                table: "LeaveApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveApplications_AspNetUsers_ModifiedByID",
                table: "LeaveApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_LeavePeriods_AspNetUsers_CreatedById",
                table: "LeavePeriods");

            migrationBuilder.DropForeignKey(
                name: "FK_LeavePeriods_AspNetUsers_ModifiedByID",
                table: "LeavePeriods");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveTypes_AspNetUsers_CreatedById",
                table: "LeaveTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveTypes_AspNetUsers_ModifiedByID",
                table: "LeaveTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_SystemCode_AspNetUsers_CreatedById",
                table: "SystemCode");

            migrationBuilder.DropForeignKey(
                name: "FK_SystemCode_AspNetUsers_ModifiedByID",
                table: "SystemCode");

            migrationBuilder.DropForeignKey(
                name: "FK_SystemCodeDetails_AspNetUsers_CreatedById",
                table: "SystemCodeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_SystemCodeDetails_AspNetUsers_ModifiedByID",
                table: "SystemCodeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_SystemProfiles_AspNetUsers_CreatedById",
                table: "SystemProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_SystemProfiles_AspNetUsers_ModifiedByID",
                table: "SystemProfiles");

            migrationBuilder.DropIndex(
                name: "IX_SystemProfiles_CreatedById",
                table: "SystemProfiles");

            migrationBuilder.DropIndex(
                name: "IX_SystemProfiles_ModifiedByID",
                table: "SystemProfiles");

            migrationBuilder.DropIndex(
                name: "IX_SystemCodeDetails_CreatedById",
                table: "SystemCodeDetails");

            migrationBuilder.DropIndex(
                name: "IX_SystemCodeDetails_ModifiedByID",
                table: "SystemCodeDetails");

            migrationBuilder.DropIndex(
                name: "IX_SystemCode_CreatedById",
                table: "SystemCode");

            migrationBuilder.DropIndex(
                name: "IX_SystemCode_ModifiedByID",
                table: "SystemCode");

            migrationBuilder.DropIndex(
                name: "IX_LeaveTypes_CreatedById",
                table: "LeaveTypes");

            migrationBuilder.DropIndex(
                name: "IX_LeaveTypes_ModifiedByID",
                table: "LeaveTypes");

            migrationBuilder.DropIndex(
                name: "IX_LeavePeriods_CreatedById",
                table: "LeavePeriods");

            migrationBuilder.DropIndex(
                name: "IX_LeavePeriods_ModifiedByID",
                table: "LeavePeriods");

            migrationBuilder.DropIndex(
                name: "IX_LeaveApplications_ApprovedByID",
                table: "LeaveApplications");

            migrationBuilder.DropIndex(
                name: "IX_LeaveApplications_CreatedById",
                table: "LeaveApplications");

            migrationBuilder.DropIndex(
                name: "IX_LeaveApplications_ModifiedByID",
                table: "LeaveApplications");

            migrationBuilder.DropIndex(
                name: "IX_LeaveAdjustmentEntries_CreatedById",
                table: "LeaveAdjustmentEntries");

            migrationBuilder.DropIndex(
                name: "IX_LeaveAdjustmentEntries_ModifiedByID",
                table: "LeaveAdjustmentEntries");

            migrationBuilder.DropIndex(
                name: "IX_Holidays_CreatedById",
                table: "Holidays");

            migrationBuilder.DropIndex(
                name: "IX_Holidays_ModifiedByID",
                table: "Holidays");

            migrationBuilder.DropIndex(
                name: "IX_Employees_CreatedById",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ModifiedByID",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Designations_CreatedById",
                table: "Designations");

            migrationBuilder.DropIndex(
                name: "IX_Designations_ModifiedByID",
                table: "Designations");

            migrationBuilder.DropIndex(
                name: "IX_Departments_CreatedById",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_ModifiedByID",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Countries_CreatedById",
                table: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Countries_ModifiedByID",
                table: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Bank_CreatedById",
                table: "Bank");

            migrationBuilder.DropIndex(
                name: "IX_Bank_ModifiedByID",
                table: "Bank");

            migrationBuilder.DropIndex(
                name: "IX_ApprovalsUserMatrixs_CreatedById",
                table: "ApprovalsUserMatrixs");

            migrationBuilder.DropIndex(
                name: "IX_ApprovalsUserMatrixs_ModifiedByID",
                table: "ApprovalsUserMatrixs");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "SystemProfiles");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "SystemCodeDetails");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "SystemCode");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "LeaveTypes");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "LeavePeriods");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "LeaveApplications");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "LeaveAdjustmentEntries");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Holidays");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Designations");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Bank");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "ApprovalsUserMatrixs");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByID",
                table: "SystemProfiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByID",
                table: "SystemCodeDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByID",
                table: "SystemCode",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByID",
                table: "LeaveTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByID",
                table: "LeavePeriods",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByID",
                table: "LeaveApplications",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedByID",
                table: "LeaveApplications",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByID",
                table: "LeaveAdjustmentEntries",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByID",
                table: "Holidays",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByID",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByID",
                table: "Designations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByID",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByID",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByID",
                table: "Bank",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByID",
                table: "ApprovalsUserMatrixs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
