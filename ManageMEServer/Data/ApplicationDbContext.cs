using ManageMEServer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ManageMEServer.Data
{
	public class ManageMeDbContext : DbContext
	{
		public ManageMeDbContext() : base("ManageMeConnectionString")
		{

		}

		public static ManageMeDbContext Create()
		{
			return new ManageMeDbContext();
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<UserPhoneInfo>()
				.HasRequired<User>(s => s.BelongToUser)
				.WithMany()
				.HasForeignKey<int>(a => a.UserId);
		}

		public DbSet<AppInfo> AppInfos { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<UserConfig> UserConfigs { get; set; }
		public DbSet<UserPhoneInfo> UserPhoneInfos { get; set; }
	}
}