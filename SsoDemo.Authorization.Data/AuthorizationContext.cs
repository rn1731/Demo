using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SsoDemo.Authorization.Domain.Model
{
    public partial class AuthorizationContext : DbContext
    {
        public AuthorizationContext(DbContextOptions<AuthorizationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<UserAccounts> UserAccounts { get; set; }
        public virtual DbSet<UserAccountScopeAllocations> UserAccountScopeAllocations { get; set; }
        public virtual DbSet<Scopes> Scopes { get; set; }
        public virtual DbSet<ClientScopeAllocations> ClientScopeAllocations { get; set; }

    }
}

