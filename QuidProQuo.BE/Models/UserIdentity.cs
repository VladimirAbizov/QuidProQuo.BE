using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace QuidProQuo.BE.Models
{
    public class UserIdentity : IIdentity
    {
        public UserIdentity(string userName)
        {
            Name = userName;
            IsAuthenticated = true;
        }

        public string Name { get; }
        public string AuthenticationType { get; }
        public bool IsAuthenticated { get; }
    }
}