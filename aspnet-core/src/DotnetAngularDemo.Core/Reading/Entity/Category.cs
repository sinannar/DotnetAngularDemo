using System;
using System.Collections.Generic;
using Abp.Dependency;
using Abp.Domain.Entities;

namespace DotnetAngularDemo.Reading.Entity
{
    public class Category : Entity<long>
    {
        public string Name { get; set; }
        public IEnumerable<ArticleCategoryMapping> ArticleMappings { get; set; }
    }
}
