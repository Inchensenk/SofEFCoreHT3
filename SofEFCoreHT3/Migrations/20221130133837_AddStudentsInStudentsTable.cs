using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SofEFCoreHT3.Migrations
{
    /// <inheritdoc />
    public partial class AddStudentsInStudentsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 3, 15), "Elen", "Storm", "+7(929)229-29-29" },
                    { 2, new DateTime(1988, 7, 13), "Mark", "Tven", "+7(919)285-87-33" },
                    { 3, new DateTime(2000, 9, 26), "Anton", "Antonov", "+7(918)335-35-33" },
                    { 4, new DateTime(2001, 6, 30), "Vikram", "Smirnov", "+7(919)288-89-93" },
                    { 5, new DateTime(2005, 2, 23), "Arseniy", "Papka", "+7(919)329-21-99" },
                    { 6, new DateTime(2003, 12, 14), "Volodya", "Doe", "+7(919)429-33-33" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
