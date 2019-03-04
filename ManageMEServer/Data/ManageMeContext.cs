using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ManageMEServer.Data
{
	public class ManageMeContext : DbContext
	{
		public System.Data.Entity.DbSet<AppInfo> AppInfoes { get; set; } // AppInfoes
		public System.Data.Entity.DbSet<User> Users { get; set; } // Users
		public System.Data.Entity.DbSet<UserConfig> UserConfigs { get; set; } // UserConfigs
		public System.Data.Entity.DbSet<UserPhoneInfo> UserPhoneInfoes { get; set; } // UserPhoneInfoes

		protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Configurations.Add(new AppInfoConfiguration());
			modelBuilder.Configurations.Add(new UserConfiguration());
			modelBuilder.Configurations.Add(new UserConfigConfiguration());
			modelBuilder.Configurations.Add(new UserPhoneInfoConfiguration());
		}
	}
	
}