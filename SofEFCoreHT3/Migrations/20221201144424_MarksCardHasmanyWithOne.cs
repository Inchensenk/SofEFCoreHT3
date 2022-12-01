using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SofEFCoreHT3.Migrations
{
    /// <inheritdoc />
    public partial class MarksCardHasmanyWithOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Marks_Cards_CardId",
                table: "Marks");

            migrationBuilder.DropForeignKey(
                name: "FK_Marks_Subjects_SubjectId",
                table: "Marks");

            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "Marks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CardId",
                table: "Marks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { 0, 0 });

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_Cards_CardId",
                table: "Marks",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_Subjects_SubjectId",
                table: "Marks",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Marks_Cards_CardId",
                table: "Marks");

            migrationBuilder.DropForeignKey(
                name: "FK_Marks_Subjects_SubjectId",
                table: "Marks");

            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "Marks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CardId",
                table: "Marks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CardId", "SubjectId" },
                values: new object[] { null, null });

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_Cards_CardId",
                table: "Marks",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_Subjects_SubjectId",
                table: "Marks",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id");
        }
    }
}
