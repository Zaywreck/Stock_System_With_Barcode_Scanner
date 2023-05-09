using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Guven_Barkod_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class f : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Barcode_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Product_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Product_Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Product_Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Product_Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Product_Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
