using System;
using Abp.Dependency;
using Abp.Domain.Entities;

namespace DotnetAngularDemo.Reading.Entity
{
    public class ArticleKeywordMapping : Entity<long>
    {
        public long ArticleId { get; set; }
        public long KeywordId { get; set; }
        public Article Article { get; set; }
        public Keyword Keyword { get; set; }

    }
}
