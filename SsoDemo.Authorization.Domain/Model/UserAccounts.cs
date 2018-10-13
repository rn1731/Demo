using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SsoDemo.Authorization.Domain.Model
{
    public partial class UserAccounts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DomainId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string PasswordSalt { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string EmailAddress { get; set; }

        public IEnumerable<UserAccountScopeAllocations> UserAccountRoleAllocations { get; set; }
        public IEnumerable<UserGrantedClientScopeAllocations> UserGrantedClientScopeAllocations { get; set; }
    }
}
