using Microsoft.EntityFrameworkCore.Migrations;

namespace BootCamp.Chapter.Migrations
{
    public partial class PeopleAndPets2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_People_PersonId",
                table: "Pets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pets",
                table: "Pets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            migrationBuilder.EnsureSchema(
                name: "PP");

            migrationBuilder.RenameTable(
                name: "Pets",
                newName: "Pet",
                newSchema: "PP");

            migrationBuilder.RenameTable(
                name: "People",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                newName: "Pets");

            migrationBuilder.RenameTable(
                name: "Person",
                schema: "PP",
                newName: "People");

            migrationBuilder.RenameIndex(
                name: "IX_Pet_PersonId",
                table: "Pets",
                newName: "IX_Pets_PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pets",
                table: "Pets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "People",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_People_PersonId",
                table: "Pets",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
