using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Data.Migrations
{
    public partial class Fixig_mistake : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateBirth",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 488, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateBirth",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 490, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateBirth",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 490, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateBirth",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 490, DateTimeKind.Local).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 5,
                column: "DateBirth",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 490, DateTimeKind.Local).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 6,
                column: "DateBirth",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 490, DateTimeKind.Local).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 7,
                column: "DateBirth",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 490, DateTimeKind.Local).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 8,
                column: "DateBirth",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 490, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 9,
                column: "DateBirth",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 490, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 10,
                column: "DateBirth",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 490, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 490, DateTimeKind.Local).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 491, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 491, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 491, DateTimeKind.Local).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 491, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 491, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 491, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "PhotoURL" },
                values: new object[] { new DateTime(2021, 4, 2, 19, 3, 36, 491, DateTimeKind.Local).AddTicks(1024), "WilliamShakespeare_Othello.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateBirth",
                value: new DateTime(2021, 3, 31, 18, 22, 42, 406, DateTimeKind.Local).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateBirth",
                value: new DateTime(2021, 3, 31, 18, 22, 42, 407, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateBirth",
                value: new DateTime(2021, 3, 31, 18, 22, 42, 407, DateTimeKind.Local).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateBirth",
                value: new DateTime(2021, 3, 31, 18, 22, 42, 407, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 5,
                column: "DateBirth",
                value: new DateTime(2021, 3, 31, 18, 22, 42, 407, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 6,
                column: "DateBirth",
                value: new DateTime(2021, 3, 31, 18, 22, 42, 407, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 7,
                column: "DateBirth",
                value: new DateTime(2021, 3, 31, 18, 22, 42, 407, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 8,
                column: "DateBirth",
                value: new DateTime(2021, 3, 31, 18, 22, 42, 407, DateTimeKind.Local).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 9,
                column: "DateBirth",
                value: new DateTime(2021, 3, 31, 18, 22, 42, 407, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 10,
                column: "DateBirth",
                value: new DateTime(2021, 3, 31, 18, 22, 42, 407, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2021, 3, 31, 18, 22, 42, 408, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2021, 3, 31, 18, 22, 42, 408, DateTimeKind.Local).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2021, 3, 31, 18, 22, 42, 408, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2021, 3, 31, 18, 22, 42, 408, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2021, 3, 31, 18, 22, 42, 408, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2021, 3, 31, 18, 22, 42, 408, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2021, 3, 31, 18, 22, 42, 408, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "PhotoURL" },
                values: new object[] { new DateTime(2021, 3, 31, 18, 22, 42, 408, DateTimeKind.Local).AddTicks(9803), "WilliamShakespeare_Othell..." });
        }
    }
}
