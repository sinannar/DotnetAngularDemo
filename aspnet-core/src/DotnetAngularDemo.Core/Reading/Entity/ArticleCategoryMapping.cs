using System;
using Abp.Dependency;
using Abp.Domain.Entities;

namespace DotnetAngularDemo.Reading.Entity
{
    public class ArticleCategoryMapping : Entity<long>
    {
        public long ArticleId { get; set; }
        public long CategoryId { get; set; }
        public Article Article { get; set; }
        public Category Category { get; set; }
    }
}
