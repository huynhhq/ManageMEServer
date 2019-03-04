﻿

// ------------------------------------------------------------------------------------------------
// This code was generated by EntityFramework Reverse POCO Generator (http://www.reversepoco.com/).
// Created by Simon Hughes (https://about.me/simon.hughes).
//
// Do not make changes directly to this file - edit the template instead.
//
// The following connection settings were used to generate this file:
//     Configuration file:     "ManageMEServer\Web.config"
//     Connection String Name: "ManageMeConnectionString"
//     Connection String:      "Data Source=.;Initial Catalog=ManageMeDB;Integrated Security=true"
// ------------------------------------------------------------------------------------------------
// Database Edition        : Express Edition (64-bit)
// Database Engine Edition : Express
// Database Version        : 14.0.1000.169

// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace ManageMEServer.Data
{

    #region POCO classes

    // AppInfoes
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class AppInfo
    {
        public int Id { get; set; } // ID (Primary key)
        public string AppName { get; set; } // AppName
        public int AppId { get; set; } // AppId
        public string GroupName { get; set; } // GroupName
        public string Address { get; set; } // Address
    }

    // HoangTest
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class HoangTest
    {
        public int Id { get; set; } // Id
        public int HoangTestId { get; set; } // HoangTestId (Primary key)
        public string Name { get; set; } // Name (length: 50)
    }

    // Users
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class User
    {
        public int Id { get; set; } // Id (Primary key)
        public string FullName { get; set; } // FullName
        public string Username { get; set; } // Username
        public string Email { get; set; } // Email
        public string Password { get; set; } // Password
        public System.DateTime CreatedDate { get; set; } // CreatedDate
        public System.DateTime DeletedDate { get; set; } // DeletedDate
        public bool IsSavingGlobal { get; set; } // IsSavingGlobal
        public bool IsDeleted { get; set; } // IsDeleted
        public string ThirdPartyId { get; set; } // ThirdPartyId
        public bool? Concu { get; set; } // Concu

        // Reverse navigation

        /// <summary>
        /// Child UserPhoneInfoes where [UserPhoneInfoes].[UserId] point to this entity (FK_dbo.UserPhoneInfoes_dbo.Users_UserId)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<UserPhoneInfo> UserPhoneInfoes { get; set; } // UserPhoneInfoes.FK_dbo.UserPhoneInfoes_dbo.Users_UserId
        /// <summary>
        /// Parent (One-to-One) User pointed by [UserConfigs].[UserConfigId] (FK_dbo.UserConfigs_dbo.Users_UserConfigId)
        /// </summary>
        public virtual UserConfig UserConfig { get; set; } // UserConfigs.FK_dbo.UserConfigs_dbo.Users_UserConfigId

        public User()
        {
            UserPhoneInfoes = new System.Collections.Generic.List<UserPhoneInfo>();
        }
    }

    // UserConfigs
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class UserConfig
    {
        public int UserConfigId { get; set; } // UserConfigId (Primary key)
        public string LanguageApp { get; set; } // LanguageApp

        // Foreign keys

        /// <summary>
        /// Parent User pointed by [UserConfigs].([UserConfigId]) (FK_dbo.UserConfigs_dbo.Users_UserConfigId)
        /// </summary>
        public virtual User User { get; set; } // FK_dbo.UserConfigs_dbo.Users_UserConfigId
    }

    // UserPhoneInfoes
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class UserPhoneInfo
    {
        public int UserPhoneInfoId { get; set; } // UserPhoneInfoId (Primary key)
        public string PhoneNumber { get; set; } // PhoneNumber
        public string HomeNetwork { get; set; } // HomeNetwork
        public bool IsNotificated { get; set; } // IsNotificated
        public int UserId { get; set; } // UserId

        // Foreign keys

        /// <summary>
        /// Parent User pointed by [UserPhoneInfoes].([UserId]) (FK_dbo.UserPhoneInfoes_dbo.Users_UserId)
        /// </summary>
        public virtual User User { get; set; } // FK_dbo.UserPhoneInfoes_dbo.Users_UserId
    }

    #endregion

    #region POCO Configuration

    // AppInfoes
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class AppInfoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AppInfo>
    {
        public AppInfoConfiguration()
            : this("dbo")
        {
        }

        public AppInfoConfiguration(string schema)
        {
            ToTable("AppInfoes", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.AppName).HasColumnName(@"AppName").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.AppId).HasColumnName(@"AppId").HasColumnType("int").IsRequired();
            Property(x => x.GroupName).HasColumnName(@"GroupName").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Address).HasColumnName(@"Address").HasColumnType("nvarchar(max)").IsOptional();
        }
    }

    // HoangTest
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class HoangTestConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<HoangTest>
    {
        public HoangTestConfiguration()
            : this("dbo")
        {
        }

        public HoangTestConfiguration(string schema)
        {
            ToTable("HoangTest", schema);
            HasKey(x => x.HoangTestId);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired();
            Property(x => x.HoangTestId).HasColumnName(@"HoangTestId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
        }
    }

    // Users
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class UserConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<User>
    {
        public UserConfiguration()
            : this("dbo")
        {
        }

        public UserConfiguration(string schema)
        {
            ToTable("Users", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.FullName).HasColumnName(@"FullName").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Username).HasColumnName(@"Username").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Email).HasColumnName(@"Email").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Password).HasColumnName(@"Password").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").HasColumnType("datetime").IsRequired();
            Property(x => x.DeletedDate).HasColumnName(@"DeletedDate").HasColumnType("datetime").IsRequired();
            Property(x => x.IsSavingGlobal).HasColumnName(@"IsSavingGlobal").HasColumnType("bit").IsRequired();
            Property(x => x.IsDeleted).HasColumnName(@"IsDeleted").HasColumnType("bit").IsRequired();
            Property(x => x.ThirdPartyId).HasColumnName(@"ThirdPartyId").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Concu).HasColumnName(@"Concu").HasColumnType("bit").IsOptional();
        }
    }

    // UserConfigs
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class UserConfigConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<UserConfig>
    {
        public UserConfigConfiguration()
            : this("dbo")
        {
        }

        public UserConfigConfiguration(string schema)
        {
            ToTable("UserConfigs", schema);
            HasKey(x => x.UserConfigId);

            Property(x => x.UserConfigId).HasColumnName(@"UserConfigId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.LanguageApp).HasColumnName(@"LanguageApp").HasColumnType("nvarchar(max)").IsOptional();

            // Foreign keys
            HasRequired(a => a.User).WithOptional(b => b.UserConfig).WillCascadeOnDelete(false); // FK_dbo.UserConfigs_dbo.Users_UserConfigId
        }
    }

    // UserPhoneInfoes
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class UserPhoneInfoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<UserPhoneInfo>
    {
        public UserPhoneInfoConfiguration()
            : this("dbo")
        {
        }

        public UserPhoneInfoConfiguration(string schema)
        {
            ToTable("UserPhoneInfoes", schema);
            HasKey(x => x.UserPhoneInfoId);

            Property(x => x.UserPhoneInfoId).HasColumnName(@"UserPhoneInfoId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PhoneNumber).HasColumnName(@"PhoneNumber").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.HomeNetwork).HasColumnName(@"HomeNetwork").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.IsNotificated).HasColumnName(@"IsNotificated").HasColumnType("bit").IsRequired();
            Property(x => x.UserId).HasColumnName(@"UserId").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.User).WithMany(b => b.UserPhoneInfoes).HasForeignKey(c => c.UserId); // FK_dbo.UserPhoneInfoes_dbo.Users_UserId
        }
    }

    #endregion

}
// </auto-generated>
