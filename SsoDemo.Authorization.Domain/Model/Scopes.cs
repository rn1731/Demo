using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SsoDemo.Authorization.Domain.Model
{
    public partial class Scopes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ScopeId { get; set; }
        [Required]
        public string System { get; set; }
        public string Api { get; set; }
        public string Method { get; set; }
        public string Access { get; set; }
        [Required]
        public string Description { get; set; }

        public IEnumerable<UserGrantedClientScopeAllocations> UserGrantedClientScopeAllocations { get; set; }
        public IEnumerable<ClientScopeAllocations> ClientScopeAllocations { get; set; }
        public IEnumerable<UserAccountScopeAllocations> UserAccountRoleAllocations { get; set; }
    }
}
