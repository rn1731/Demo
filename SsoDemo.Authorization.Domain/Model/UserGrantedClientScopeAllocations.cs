using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SsoDemo.Authorization.Domain.Model
{
    public class UserGrantedClientScopeAllocations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserGrantedClientScopeAllocationId { get; set; }
        [Required]
        [ForeignKey("UserAccount")]
        public int UserAccountId { get; set; }
        [Required]
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        [Required]
        [ForeignKey("Scope")]
        public int ScopeId { get; set; }

        public UserAccounts UserAccount { get; set; }
        public Clients Client { get; set; }
        public Scopes Scope { get; set; }
    }
}
