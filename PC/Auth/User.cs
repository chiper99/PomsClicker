using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PC.Auth
{
    public class User : IdentityUser
    {
        decimal money;
        uint booster1;
        uint booster2;
        uint booster3;
    }
}
