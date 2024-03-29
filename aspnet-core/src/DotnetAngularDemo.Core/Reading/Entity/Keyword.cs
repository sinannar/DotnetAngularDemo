using System;
using System.Collections.Generic;
using Abp.Dependency;
using Abp.Domain.Entities;

namespace DotnetAngularDemo.Reading.Entity
{
    public class Keyword : Entity<long>
    {
        public string Word { get; set; }
        public IEnumerable<ArticleKeywordMapping> ArticleMappings { get; set; }
    }
}
