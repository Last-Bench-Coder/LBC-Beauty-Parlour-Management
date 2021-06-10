using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LBC.Beauty.Parlour.Management.Service.Authentication
{
    public interface IJwtAuthenticationManager
    {
        string Authenticate(string username, string password);
    }
}
