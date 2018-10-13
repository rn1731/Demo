using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SsoDemo.Authorization.Domain.Model
{
    public class UserAccountScopeAllocations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserAccountScopeAllocationId { get; set; }
        [ForeignKey("UserAccount")]
        public int UserAccountId { get; set; }
        [ForeignKey("Scope")]
        public int ScopeId { get; set; }

        public UserAccounts UserAccount { get; set; }
        public Scopes Scope { get; set; }
    }
}
