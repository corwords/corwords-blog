using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Corwords.Migrations
{
    public partial class InitialCorwordsContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Corwords_Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Url = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corwords_Blogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Corwords_BlogEnclosures",
                columns: table => new
                {
                    EnclosureId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Length = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corwords_BlogEnclosures", x => x.EnclosureId);
                });

            migrationBuilder.CreateTable(
                name: "Corwords_BlogMediaObjects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bits = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corwords_BlogMediaObjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Corwords_BlogMediaObjectInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corwords_BlogMediaObjectInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Corwords_BlogSources",
                columns: table => new
                {
                    SourceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corwords_BlogSources", x => x.SourceId);
                });

            migrationBuilder.CreateTable(
                name: "Corwords_BlogTags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Title = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corwords_BlogTags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Corwords_BlogPosts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Author = table.Column<string>(maxLength: 255, nullable: false),
                    AuthorUsername = table.Column<string>(maxLength: 255, nullable: true),
                    BlogId = table.Column<int>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdate = table.Column<DateTime>(nullable: false),
                    Slug = table.Column<string>(maxLength: 255, nullable: true),
                    Title = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corwords_BlogPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Corwords_BlogPosts_Corwords_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Corwords_Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Corwords_BlogPostTags",
                columns: table => new
                {
                    PostTagId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PostId = table.Column<int>(nullable: false),
                    TagId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corwords_BlogPostTags", x => x.PostTagId);
                    table.ForeignKey(
                        name: "FK_Corwords_BlogPostTags_Corwords_BlogPosts_PostId",
                        column: x => x.PostId,
                        principalTable: "Corwords_BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Corwords_BlogPostTags_Corwords_BlogTags_TagId",
                        column: x => x.TagId,
                        principalTable: "Corwords_BlogTags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Corwords_BlogPosts_BlogId",
                table: "Corwords_BlogPosts",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Corwords_BlogPostTags_PostId",
                table: "Corwords_BlogPostTags",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Corwords_BlogPostTags_TagId",
                table: "Corwords_BlogPostTags",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Corwords_BlogEnclosures");

            migrationBuilder.DropTable(
                name: "Corwords_BlogMediaObjects");

            migrationBuilder.DropTable(
                name: "Corwords_BlogMediaObjectInfos");

            migrationBuilder.DropTable(
                name: "Corwords_BlogPostTags");

            migrationBuilder.DropTable(
                name: "Corwords_BlogSources");

            migrationBuilder.DropTable(
                name: "Corwords_BlogPosts");

            migrationBuilder.DropTable(
                name: "Corwords_BlogTags");

            migrationBuilder.DropTable(
                name: "Corwords_Blogs");
        }
    }
}