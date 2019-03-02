using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManageMEServer.Models
{
	public class UserConfig
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Key]
		public int UserConfigId { get; set; }
		public string LanguageApp { get; set; }

		public virtual User BelongToUser { get; set; }
	}
}