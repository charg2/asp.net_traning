using System.ComponentModel.DataAnnotations;

namespace EFCoreTraning.Models
{
    public class User
    {
        /// <summary>
        /// 사용자 번호
        /// </summary>
        [Key]
        public int UserNo { get; set; }

        [Required]
        public string UserName {  get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public string UserPassword {  get; set; }
    }
}
