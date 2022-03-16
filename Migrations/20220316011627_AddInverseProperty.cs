using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab1_DataAnnotations_Hotel.Migrations
{
    public partial class AddInverseProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PreviousClientId",
                table: "Room",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentClientId",
                table: "Room",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Room_CurrentClientId",
                table: "Room",
                column: "CurrentClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_PreviousClientId",
                table: "Room",
                column: "PreviousClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Client_CurrentClientId",
                table: "Room",
                column: "CurrentClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Client_PreviousClientId",
                table: "Room",
                column: "PreviousClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Room_Client_CurrentClientId",
                table: "Room");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_Client_PreviousClientId",
                table: "Room");

            migrationBuilder.DropIndex(
                name: "IX_Room_CurrentClientId",
                table: "Room");

            migrationBuilder.DropIndex(
                name: "IX_Room_PreviousClientId",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "CurrentClientId",
                table: "Room");

            migrationBuilder.RenameColumn(
                name: "PreviousClientId",
                table: "Room",
                newName: "Id");
        }
    }
}
