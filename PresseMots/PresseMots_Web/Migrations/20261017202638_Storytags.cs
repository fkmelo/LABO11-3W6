using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PresseMots.Migrations
{
    /// <inheritdoc />
    public partial class Storytags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoryTag_Stories_storysId",
                table: "StoryTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoryTag",
                table: "StoryTag");

            migrationBuilder.DropIndex(
                name: "IX_StoryTag_storysId",
                table: "StoryTag");

            migrationBuilder.RenameColumn(
                name: "storysId",
                table: "StoryTag",
                newName: "StorysId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoryTag",
                table: "StoryTag",
                columns: new[] { "StorysId", "TagsId" });

            migrationBuilder.CreateTable(
                name: "StoryTags",
                columns: table => new
                {
                    StoryTagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoryId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoryTags", x => x.StoryTagId);
                    table.ForeignKey(
                        name: "FK_StoryTags_Stories_StoryId",
                        column: x => x.StoryId,
                        principalTable: "Stories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoryTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StoryTag_TagsId",
                table: "StoryTag",
                column: "TagsId");

            migrationBuilder.CreateIndex(
                name: "IX_StoryTags_StoryId",
                table: "StoryTags",
                column: "StoryId");

            migrationBuilder.CreateIndex(
                name: "IX_StoryTags_TagId",
                table: "StoryTags",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_StoryTag_Stories_StorysId",
                table: "StoryTag",
                column: "StorysId",
                principalTable: "Stories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoryTag_Stories_StorysId",
                table: "StoryTag");

            migrationBuilder.DropTable(
                name: "StoryTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoryTag",
                table: "StoryTag");

            migrationBuilder.DropIndex(
                name: "IX_StoryTag_TagsId",
                table: "StoryTag");

            migrationBuilder.RenameColumn(
                name: "StorysId",
                table: "StoryTag",
                newName: "storysId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoryTag",
                table: "StoryTag",
                columns: new[] { "TagsId", "storysId" });

            migrationBuilder.CreateIndex(
                name: "IX_StoryTag_storysId",
                table: "StoryTag",
                column: "storysId");

            migrationBuilder.AddForeignKey(
                name: "FK_StoryTag_Stories_storysId",
                table: "StoryTag",
                column: "storysId",
                principalTable: "Stories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
