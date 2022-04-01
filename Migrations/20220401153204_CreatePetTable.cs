using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_bakery.Migrations
{
    public partial class CreatePetTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "petOwnerId",
                table: "Pets",
                newName: "ownedById");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_ownedById",
                table: "Pets",
                column: "ownedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_PetOwners_ownedById",
                table: "Pets",
                column: "ownedById",
                principalTable: "PetOwners",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_PetOwners_ownedById",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Pets_ownedById",
                table: "Pets");

            migrationBuilder.RenameColumn(
                name: "ownedById",
                table: "Pets",
                newName: "petOwnerId");
        }
    }
}
