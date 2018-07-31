using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DotnetAngularDemo.Authorization.Roles;
using DotnetAngularDemo.Authorization.Users;
using DotnetAngularDemo.MultiTenancy;
using DotnetAngularDemo.Reading.Entity;

namespace DotnetAngularDemo.EntityFrameworkCore
{
    public class DotnetAngularDemoDbContext : AbpZeroDbContext<Tenant, Role, User, DotnetAngularDemoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Keyword> Keywords { get; set; }
        public virtual DbSet<ArticleCategoryMapping> ArticleCategoryMappings { get; set; }
        public virtual DbSet<ArticleKeywordMapping> ArticleKeywordMappings { get; set; }

        public DotnetAngularDemoDbContext(DbContextOptions<DotnetAngularDemoDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ArticleCategoryMapping>(acm => {
                acm.HasOne(m => m.Article)
                    .WithMany(f => f.CategoryMappings)
                    .HasPrincipalKey(f => f.Id)
                    .HasForeignKey(m => m.ArticleId)
                    .HasConstraintName("FK_ArticleCategoryMapping_Article");

                acm.HasOne(m => m.Category)
                    .WithMany(m => m.ArticleMappings)
                    .HasPrincipalKey(m => m.Id)
                    .HasForeignKey(m => m.CategoryId)
                    .HasConstraintName("FK_ArticleCategoryMapping_Category");
            });

            modelBuilder.Entity<ArticleKeywordMapping>(akm => {
                akm.HasOne(m => m.Article)
                    .WithMany(f => f.KeywordMappings)
                    .HasPrincipalKey(f => f.Id)
                    .HasForeignKey(m => m.KeywordId)
                    .HasConstraintName("FK_ArticleKeywordMapping_Article");

                akm.HasOne(m => m.Keyword)
                    .WithMany(m => m.ArticleMappings)
                    .HasPrincipalKey(m => m.Id)
                    .HasForeignKey(m => m.ArticleId)
                    .HasConstraintName("FK_ArticleKeywordMapping_Keyword");
            });

        }
    }
}
