using System.ComponentModel.DataAnnotations;

namespace ManageMEServer.Models
{
	public class UserPhoneInfo
	{
		[Key]
		public int UserPhoneInfoId { get; set; }
		public string PhoneNumber { get; set; }
		public string HomeNetwork { get; set; }
		public bool IsNotificated { get; set; }

		public int UserId { get; set; }
		public User BelongToUser { get; set; }
	}
}