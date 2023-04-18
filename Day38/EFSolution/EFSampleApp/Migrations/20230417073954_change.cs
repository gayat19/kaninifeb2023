using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFSampleApp.Migrations
{
    public partial class change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Rating",
                table: "Movies",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingNumber",
                keyValue: 1000,
                column: "ShowDate",
                value: new DateTime(2023, 4, 17, 13, 9, 53, 755, DateTimeKind.Local).AddTicks(3532));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Rating",
                table: "Movies",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingNumber",
                keyValue: 1000,
                column: "ShowDate",
                value: new DateTime(2023, 4, 17, 12, 52, 19, 600, DateTimeKind.Local).AddTicks(9145));
        }
    }
}
