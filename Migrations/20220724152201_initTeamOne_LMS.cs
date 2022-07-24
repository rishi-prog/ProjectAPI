using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectAPI.Migrations
{
    public partial class initTeamOne_LMS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "10001, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeMobieNumber = table.Column<long>(type: "bigint", nullable: false),
                    DateOfJoin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "LeaveType",
                columns: table => new
                {
                    LeaveTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "889897, 90869"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    SickLeave = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaternityLeave = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EarnedLeave = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveType", x => x.LeaveTypeID);
                    table.ForeignKey(
                        name: "FK_LeaveType_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Manager",
                columns: table => new
                {
                    ManagerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "5001, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ManagerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerMobileNumber = table.Column<long>(type: "bigint", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager", x => x.ManagerId);
                    table.ForeignKey(
                        name: "FK_Manager_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeaveSection",
                columns: table => new
                {
                    LeaveID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "909989, 439587"),
                    NumberOfDay = table.Column<int>(type: "int", nullable: false),
                    StrartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppliedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ManagerComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveSection", x => x.LeaveID);
                    table.ForeignKey(
                        name: "FK_LeaveSection_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId");
                    table.ForeignKey(
                        name: "FK_LeaveSection_Manager_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Manager",
                        principalColumn: "ManagerId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveSection_EmployeeId",
                table: "LeaveSection",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveSection_ManagerId",
                table: "LeaveSection",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveType_EmployeeId",
                table: "LeaveType",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Manager_EmployeeId",
                table: "Manager",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveSection");

            migrationBuilder.DropTable(
                name: "LeaveType");

            migrationBuilder.DropTable(
                name: "Manager");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
