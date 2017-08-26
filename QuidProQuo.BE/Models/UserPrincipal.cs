using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace QuidProQuo.BE.Models
{
    public class UserPrincipal : IPrincipal
    {
        public UserPrincipal(string userName)
        {
            Identity = new UserIdentity(userName);
        }

        public bool IsInRole(string role)
        {
            /// TODO Необходимо обращаться за полуением роли.
            return true;
        }

        public IIdentity Identity { get; }
    }
}