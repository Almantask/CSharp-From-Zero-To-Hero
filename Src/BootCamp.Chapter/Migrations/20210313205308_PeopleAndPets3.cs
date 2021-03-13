using Microsoft.EntityFrameworkCore.Migrations;

namespace BootCamp.Chapter.Migrations
{
    public partial class PeopleAndPets3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pet_Person_PersonId",
                schema: "PP",
                table: "Pet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pet",
                schema: "PP",
                table: "Pet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                schema: "PP",
                table: "Person");

            migrationBuilder.RenameTable(
                name: "Pet",
                schema: "PP",
                newName: "Pets",
                newSchema: "PP");

            migrationBuilder.RenameTable(
                name: "Person",
                schema: "PP",
                newName: "People",
                newSchema: "PP");

            migrationBuilder.RenameIndex(
                name: "IX_Pet_PersonId",
                schema: "PP",
                table: "Pets",
                newName: "IX_Pets_PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pets",
                schema: "PP",
                table: "Pets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                schema: "PP",
                table: "People",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_People_PersonId",
                schema: "PP",
                table: "Pets",
                column: "PersonId",
                principalSchema: "PP",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_People_PersonId",
                schema: "PP",
                table: "Pets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pets",
                schema: "PP",
                table: "Pets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                schema: "PP",
                table: "People");

            migrationBuilder.RenameTable(
                name: "Pets",
                schema: "PP",
                newName: "Pet",
                newSchema: "PP");

            migrationBuilder.RenameTable(
                name: "People",
                schema: "PP",
                newName: "Person",
                newSchema: "PP");

            migrationBuilder.RenameIndex(
                name: "IX_Pets_PersonId",
                schema: "PP",
                table: "Pet",
                newName: "IX_Pet_PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pet",
                schema: "PP",
                table: "Pet",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                schema: "PP",
                table: "Person",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_Person_PersonId",
                schema: "PP",
                table: "Pet",
                column: "PersonId",
                principalSchema: "PP",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
