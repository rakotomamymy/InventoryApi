using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Ef.Migrations
{
    public partial class initData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArticleTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ref = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    ArticleTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_ArticleTypes_ArticleTypeId",
                        column: x => x.ArticleTypeId,
                        principalTable: "ArticleTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ArticleTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Alimentaire" });

            migrationBuilder.InsertData(
                table: "ArticleTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Non alimentaire" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "ArticleTypeId", "Name", "Price", "Quantity", "Ref" },
                values: new object[,]
                {
                    { 38, 1, "apple", 10f, 6, "0001" },
                    { 21, 2, "Article3", 5f, 3, "00022" },
                    { 22, 2, "Article4", 9f, 4, "00023" },
                    { 23, 2, "Article5", 7f, 5, "00024" },
                    { 24, 2, "Article6", 5f, 6, "00025" },
                    { 25, 2, "Article7", 6f, 7, "00026" },
                    { 26, 2, "Article8", 1f, 8, "00027" },
                    { 27, 2, "Article9", 12f, 9, "00028" },
                    { 28, 2, "Article10", 15f, 1, "00029" },
                    { 29, 2, "Article11", 15f, 3, "00030" },
                    { 30, 2, "Article12", 13f, 9, "00031" },
                    { 31, 2, "Article13", 16f, 7, "00032" },
                    { 32, 2, "Article14", 19f, 5, "00033" },
                    { 33, 2, "Article15", 18f, 2, "00034" },
                    { 34, 2, "Article16", 8f, 2, "00035" },
                    { 35, 2, "Article17", 7f, 3, "00036" },
                    { 20, 2, "Article2", 3f, 2, "00021" },
                    { 19, 2, "Article1", 2f, 1, "00020" },
                    { 18, 1, "cucumber", 12f, 9, "00019" },
                    { 17, 1, "cranberry", 16f, 8, "00018" },
                    { 1, 1, "apricot", 2f, 3, "0002" },
                    { 2, 1, "avocado", 7f, 4, "0003" },
                    { 3, 1, "banana", 15f, 6, "0004" },
                    { 4, 1, "bell pepper", 6f, 8, "0005" },
                    { 5, 1, "bilberry", 8f, 7, "0006" },
                    { 6, 1, "blackberry", 6f, 9, "0007" },
                    { 7, 1, "blackcurrant", 7f, 4, "0008" },
                    { 36, 2, "Article18", 6f, 8, "00037" },
                    { 8, 1, "blueberry", 10f, 6, "0009" },
                    { 10, 1, "breadfruit", 13f, 1, "00011" },
                    { 11, 1, "cantaloupe", 19f, 2, "00012" },
                    { 12, 1, "cherimoya", 15f, 3, "00013" },
                    { 13, 1, "cherry", 13f, 4, "00014" },
                    { 14, 1, "clementine", 12f, 5, "00015" },
                    { 15, 1, "cloudberry", 19f, 6, "00016" },
                    { 16, 1, "coconut", 14f, 7, "00017" },
                    { 9, 1, "boysenberry", 12f, 7, "00010" },
                    { 37, 2, "Article19", 3f, 9, "00038" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleTypeId",
                table: "Articles",
                column: "ArticleTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "ArticleTypes");
        }
    }
}
