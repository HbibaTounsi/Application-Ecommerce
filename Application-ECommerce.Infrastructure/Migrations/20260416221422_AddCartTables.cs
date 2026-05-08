using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application_ECommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCartTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartDetails_CartHeader_CartHeaderId",
                table: "CartDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_CartHeader_AspNetUsers_UserId",
                table: "CartHeader");

            migrationBuilder.DropForeignKey(
                name: "FK_CartHeader_Coupons_CouponId",
                table: "CartHeader");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartHeader",
                table: "CartHeader");

            migrationBuilder.RenameTable(
                name: "CartHeader",
                newName: "CartHeaders");

            migrationBuilder.RenameIndex(
                name: "IX_CartHeader_UserId",
                table: "CartHeaders",
                newName: "IX_CartHeaders_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_CartHeader_CouponId",
                table: "CartHeaders",
                newName: "IX_CartHeaders_CouponId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartHeaders",
                table: "CartHeaders",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetails_CartHeaders_CartHeaderId",
                table: "CartDetails",
                column: "CartHeaderId",
                principalTable: "CartHeaders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartHeaders_AspNetUsers_UserId",
                table: "CartHeaders",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartHeaders_Coupons_CouponId",
                table: "CartHeaders",
                column: "CouponId",
                principalTable: "Coupons",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartDetails_CartHeaders_CartHeaderId",
                table: "CartDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_CartHeaders_AspNetUsers_UserId",
                table: "CartHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_CartHeaders_Coupons_CouponId",
                table: "CartHeaders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartHeaders",
                table: "CartHeaders");

            migrationBuilder.RenameTable(
                name: "CartHeaders",
                newName: "CartHeader");

            migrationBuilder.RenameIndex(
                name: "IX_CartHeaders_UserId",
                table: "CartHeader",
                newName: "IX_CartHeader_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_CartHeaders_CouponId",
                table: "CartHeader",
                newName: "IX_CartHeader_CouponId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartHeader",
                table: "CartHeader",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetails_CartHeader_CartHeaderId",
                table: "CartDetails",
                column: "CartHeaderId",
                principalTable: "CartHeader",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartHeader_AspNetUsers_UserId",
                table: "CartHeader",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartHeader_Coupons_CouponId",
                table: "CartHeader",
                column: "CouponId",
                principalTable: "Coupons",
                principalColumn: "Id");
        }
    }
}
