using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanduValorant.Models
{
    public class FirebaseAuthenticationResponseBody
    {
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string ExpiresIn { get; set; }
        public string IdToken { get; set; }
        public string Kind { get; set; }
        public string LocalId { get; set; }
        public bool Registered { get; set; }
        public string RefreshToken { get; set; }
    }
}
