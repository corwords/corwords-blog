using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Corwords.Data;

namespace Corwords.Migrations.Corwords
{
    [DbContext(typeof(CorwordsContext))]
    [Migration("20161007183943_InitializeCorwordsContext")]
    partial class InitializeCorwordsContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Corwords.Data.Blog.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Description");

                    b.Property<string>("Title");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Corwords.Data.Blog.Enclosure", b =>
                {
                    b.Property<int>("EnclosureId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Length");

                    b.Property<string>("Type");

                    b.Property<string>("Url");

                    b.HasKey("EnclosureId");

                    b.ToTable("Enclosures");
                });

            modelBuilder.Entity("Corwords.Data.Blog.IndividualBlog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Url");

                    b.HasKey("BlogId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Corwords.Data.Blog.MediaObject", b =>
                {
                    b.Property<int>("MediaObjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bits");

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.HasKey("MediaObjectId");

                    b.ToTable("MediaObjects");
                });

            modelBuilder.Entity("Corwords.Data.Blog.MediaObjectInfo", b =>
                {
                    b.Property<int>("MediaObjectInfoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Url");

                    b.HasKey("MediaObjectInfoId");

                    b.ToTable("MediaObjectInfos");
                });

            modelBuilder.Entity("Corwords.Data.Blog.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<string>("AuthorUsername");

                    b.Property<int?>("BlogId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateUpdated");

                    b.Property<string>("Slug");

                    b.Property<string>("Title");

                    b.HasKey("PostId");

                    b.HasIndex("BlogId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Corwords.Data.Blog.PostCategory", b =>
                {
                    b.Property<int>("PostCategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<int>("PostId");

                    b.HasKey("PostCategoryId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PostId");

                    b.ToTable("PostCategory");
                });

            modelBuilder.Entity("Corwords.Data.Blog.Source", b =>
                {
                    b.Property<int>("SourceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Url");

                    b.HasKey("SourceId");

                    b.ToTable("Sources");
                });

            modelBuilder.Entity("Corwords.Data.Blog.Post", b =>
                {
                    b.HasOne("Corwords.Data.Blog.IndividualBlog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId");
                });

            modelBuilder.Entity("Corwords.Data.Blog.PostCategory", b =>
                {
                    b.HasOne("Corwords.Data.Blog.Category", "Category")
                        .WithMany("PostCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Corwords.Data.Blog.Post", "Post")
                        .WithMany("PostCategories")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
