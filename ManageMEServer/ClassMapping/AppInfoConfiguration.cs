using ManageMEServer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ManageMEServer.ClassMapping
{
	public class AppInfoConfiguration : EntityTypeConfiguration<AppInfo>	 
	{
		public AppInfoConfiguration()
		{
			ToTable("tblAppInfo");
		}
	}
}