using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManageMEServer.Models
{
	public class AppInfo
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Key]
		public int ID { get; set; }
		public string AppName { get; set; }
		public int AppId { get; set; }
		public string GroupName { get; set; }
		public string Address { get; set; }
	}
}