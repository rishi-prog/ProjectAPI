using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectAPI.Migrations
{
    public partial class initLMS_TeamOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeMobieNumber = table.Column<long>(type: "bigint", nullable: false),
                    DateOfJoin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvailabeleBalanceLeave = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
