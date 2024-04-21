using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Btchuong3.Migrations
{
    /// <inheritdoc />
    public partial class intial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "publishers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_publishers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    BookID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRead = table.Column<bool>(type: "bit", nullable: true),
                    DateRead = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Rate = table.Column<int>(type: "int", nullable: true),
                    Genre = table.Column<int>(type: "int", nullable: true),
                    CoverUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PublisherID = table.Column<int>(type: "int", nullable: false),
                    PublishersID = table.Column<int>(type: "int", nullable: true),
                    AuthorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.BookID);
                    table.ForeignKey(
                        name: "FK_books_authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "authors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_books_publishers_PublishersID",
                        column: x => x.PublishersID,
                        principalTable: "publishers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "book_Authors",
                columns: table => new
                {
                    BookID = table.Column<int>(type: "int", nullable: false),
                    AuthorID = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_book_Authors", x => new { x.BookID, x.AuthorID });
                    table.ForeignKey(
                        name: "FK_book_Authors_authors_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_book_Authors_books_BookID",
                        column: x => x.BookID,
                        principalTable: "books",
                        principalColumn: "BookID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_book_Authors_AuthorID",
                table: "book_Authors",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_books_AuthorId",
                table: "books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_books_PublishersID",
                table: "books",
                column: "PublishersID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "book_Authors");

            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "authors");

            migrationBuilder.DropTable(
                name: "publishers");
        }
    }
}
