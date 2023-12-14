using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanduValorant.Services.AccountManagement.Login
{
    public interface IGanduCheatsLogin
    {
        Task<string> Login(string email, string password);
    }
}
