using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Corwords.Data;

namespace Corwords.Migrations
{
    [DbContext(typeof(CorwordsContext))]
    partial class CorwordsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Corwords.Core.Blog.EntityFrameworkCore.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

                    b.HasKey("Id");

                    b.ToTable("Corwords_Blogs");
                });

            modelBuilder.Entity("Corwords.Core.Blog.EntityFrameworkCore.BlogPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("AuthorUsername")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<int?>("BlogId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateUpdate");

                    b.Property<string>("Slug")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.ToTable("Corwords_BlogPosts");
                });

            modelBuilder.Entity("Corwords.Core.Blog.EntityFrameworkCore.Enclosure", b =>
                {
                    b.Property<int>("EnclosureId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Length");

                    b.Property<string>("Type");

                    b.Property<string>("Url");

                    b.HasKey("EnclosureId");

                    b.ToTable("Corwords_BlogEnclosures");
                });

            modelBuilder.Entity("Corwords.Core.Blog.EntityFrameworkCore.MediaObject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bits");

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Corwords_BlogMediaObjects");
                });

            modelBuilder.Entity("Corwords.Core.Blog.EntityFrameworkCore.MediaObjectInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Corwords_BlogMediaObjectInfos");
                });

            modelBuilder.Entity("Corwords.Core.Blog.EntityFrameworkCore.PostTag", b =>
                {
                    b.Property<int>("PostTagId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PostId");

                    b.Property<int>("TagId");

                    b.HasKey("PostTagId");

                    b.HasIndex("PostId");

                    b.HasIndex("TagId");

                    b.ToTable("Corwords_BlogPostTags");
                });

            modelBuilder.Entity("Corwords.Core.Blog.EntityFrameworkCore.Source", b =>
                {
                    b.Property<int>("SourceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Url");

                    b.HasKey("SourceId");

                    b.ToTable("Corwords_BlogSources");
                });

            modelBuilder.Entity("Corwords.Core.Blog.EntityFrameworkCore.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Description");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

                    b.HasKey("Id");

                    b.ToTable("Corwords_BlogTags");
                });

            modelBuilder.Entity("Corwords.Core.Blog.EntityFrameworkCore.BlogPost", b =>
                {
                    b.HasOne("Corwords.Core.Blog.EntityFrameworkCore.Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId");
                });

            modelBuilder.Entity("Corwords.Core.Blog.EntityFrameworkCore.PostTag", b =>
                {
                    b.HasOne("Corwords.Core.Blog.EntityFrameworkCore.BlogPost", "Post")
                        .WithMany("PostTags")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Corwords.Core.Blog.EntityFrameworkCore.Tag", "Tag")
                        .WithMany("PostTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
