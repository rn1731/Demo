using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SsoDemo.Authorization.Domain.Model
{
    public partial class Clients
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Key { get; set; }
        [Required]
        public string Secret { get; set; }

        public IEnumerable<UserGrantedClientScopeAllocations> UserGrantedClientScopeAllocations { get; set; }
        public IEnumerable<ClientScopeAllocations> ClientScopeAllocations { get; set; }
    }
}
