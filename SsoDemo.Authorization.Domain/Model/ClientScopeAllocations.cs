using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SsoDemo.Authorization.Domain.Model
{
    public class ClientScopeAllocations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientRoleAllocationId { get; set; }
        [Required]
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        [Required]
        [ForeignKey("Scope")]
        public int ScopeId { get; set; }

        public Clients Client { get; set; }
        public Scopes Scope { get; set; }
    }
}
