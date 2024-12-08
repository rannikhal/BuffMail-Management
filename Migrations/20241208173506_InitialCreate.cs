using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuffMail_Management.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resident",
                columns: table => new
                {
                    ResidentID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false),
                    UnitNumber = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resident", x => x.ResidentID);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffID);
                });

            migrationBuilder.CreateTable(
                name: "Package",
                columns: table => new
                {
                    PackageID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PostalServiceAgency = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    InProcessDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    OutProcessDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PackageStatus = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    TrackingCode = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false),
                    ResidentID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Package", x => x.PackageID);
                    table.ForeignKey(
                        name: "FK_Package_Resident_ResidentID",
                        column: x => x.ResidentID,
                        principalTable: "Resident",
                        principalColumn: "ResidentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Package_ResidentID",
                table: "Package",
                column: "ResidentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Package");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Resident");
        }
    }
}
