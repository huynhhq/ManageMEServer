using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManageMEServer.Models
{
	public class User
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Key]
		public int Id { get; set; }
		public string FullName { get; set; }
		public string Username { get; set; }
		public string UserID { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime DeletedDate { get; set; }
		public bool IsSavingGlobal { get; set; }
		public bool IsDeleted { get; set; }

		public virtual UserConfig config{ get; set; }
		public ICollection<UserPhoneInfo> userPhoneInfos { get; set; }
	}
}