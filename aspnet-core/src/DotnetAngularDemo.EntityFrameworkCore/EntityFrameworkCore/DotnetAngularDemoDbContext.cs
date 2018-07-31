using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DotnetAngularDemo.Authorization.Roles;
using DotnetAngularDemo.Authorization.Users;
using DotnetAngularDemo.MultiTenancy;

namespace DotnetAngularDemo.EntityFrameworkCore
{
    public class DotnetAngularDemoDbContext : AbpZeroDbContext<Tenant, Role, User, DotnetAngularDemoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DotnetAngularDemoDbContext(DbContextOptions<DotnetAngularDemoDbContext> options)
            : base(options)
        {
        }
    }
}
