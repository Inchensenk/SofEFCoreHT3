using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SofEFCoreHT3.Migrations
{
    /// <inheritdoc />
    public partial class SubjectHasManyToCardsWithManyСreationTableEnrollments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardSubject_Cards_CardsId",
                table: "CardSubject");

            migrationBuilder.DropForeignKey(
                name: "FK_CardSubject_Subjects_SubjectsId",
                table: "CardSubject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardSubject",
                table: "CardSubject");

            migrationBuilder.RenameTable(
                name: "CardSubject",
                newName: "Enrollments");

            migrationBuilder.RenameIndex(
                name: "IX_CardSubject_SubjectsId",
                table: "Enrollments",
                newName: "IX_Enrollments_SubjectsId");

            migrationBuilder.AddColumn<int>(
                name: "CardId",
                table: "Subjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CardId",
                table: "Marks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "Marks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enrollments",
                table: "Enrollments",
                columns: new[] { "CardsId", "SubjectsId" });

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

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CardId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CardId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CardId",
                value: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Marks_CardId",
                table: "Marks",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_Marks_SubjectId",
                table: "Marks",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Cards_CardsId",
                table: "Enrollments",
                column: "CardsId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Subjects_SubjectsId",
                table: "Enrollments",
                column: "SubjectsId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Cards_CardsId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Subjects_SubjectsId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Marks_Cards_CardId",
                table: "Marks");

            migrationBuilder.DropForeignKey(
                name: "FK_Marks_Subjects_SubjectId",
                table: "Marks");

            migrationBuilder.DropIndex(
                name: "IX_Marks_CardId",
                table: "Marks");

            migrationBuilder.DropIndex(
                name: "IX_Marks_SubjectId",
                table: "Marks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enrollments",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "CardId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "CardId",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "Cards");

            migrationBuilder.RenameTable(
                name: "Enrollments",
                newName: "CardSubject");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollments_SubjectsId",
                table: "CardSubject",
                newName: "IX_CardSubject_SubjectsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardSubject",
                table: "CardSubject",
                columns: new[] { "CardsId", "SubjectsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CardSubject_Cards_CardsId",
                table: "CardSubject",
                column: "CardsId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CardSubject_Subjects_SubjectsId",
                table: "CardSubject",
                column: "SubjectsId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
