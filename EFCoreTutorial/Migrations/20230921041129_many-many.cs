using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreTutorial.Migrations
{
    /// <inheritdoc />
    public partial class manymany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookGenre_Book_BooksId",
                table: "BookGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_BookGenre_Genre_GenresId",
                table: "BookGenre");

            migrationBuilder.RenameColumn(
                name: "GenresId",
                table: "BookGenre",
                newName: "GenreId");

            migrationBuilder.RenameColumn(
                name: "BooksId",
                table: "BookGenre",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_BookGenre_GenresId",
                table: "BookGenre",
                newName: "IX_BookGenre_GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookGenre_Book_BookId",
                table: "BookGenre",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookGenre_Genre_GenreId",
                table: "BookGenre",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookGenre_Book_BookId",
                table: "BookGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_BookGenre_Genre_GenreId",
                table: "BookGenre");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "BookGenre",
                newName: "GenresId");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "BookGenre",
                newName: "BooksId");

            migrationBuilder.RenameIndex(
                name: "IX_BookGenre_GenreId",
                table: "BookGenre",
                newName: "IX_BookGenre_GenresId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookGenre_Book_BooksId",
                table: "BookGenre",
                column: "BooksId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookGenre_Genre_GenresId",
                table: "BookGenre",
                column: "GenresId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
