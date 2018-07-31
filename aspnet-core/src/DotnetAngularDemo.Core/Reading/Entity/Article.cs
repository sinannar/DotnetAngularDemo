using System;
using System.Collections.Generic;
using Abp.Dependency;
using Abp.Domain.Entities;

namespace DotnetAngularDemo.Reading.Entity
{
    public class Article : Entity<long>
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public int ReadCount { get; set; }
        public IEnumerable<ArticleCategoryMapping> CategoryMappings { get; set; }
        public IEnumerable<ArticleKeywordMapping> KeywordMappings { get; set; }
    }
}
