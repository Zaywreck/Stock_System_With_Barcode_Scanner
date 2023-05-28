using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Guven_Barkod_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class PurchPrice_Added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Product_Purch_Price",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Product_Purch_Price",
                table: "Products");
        }
    }
}
