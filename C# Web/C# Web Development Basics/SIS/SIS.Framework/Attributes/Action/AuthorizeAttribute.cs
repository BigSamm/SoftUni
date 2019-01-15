namespace SIS.Framework.Attributes.Action
{
    using System;
    using System.Linq;

    using Security.Contracts;

    public class AuthorizeAttribute : Attribute
    {
        private readonly string role;

        public AuthorizeAttribute()
        { }

        public AuthorizeAttribute(string role)
        {
            this.role = role;
        }

        private bool IsIdentityPresent(IIdentity identity)
        {
            return identity != null;
        }

        private bool IsIdentityInRole(IIdentity identity)
        {
            if (this.IsIdentityPresent(identity))
            {
                if (identity.Roles.Any(x => x == this.role))
                    return true;
            }

            return false;
        }

        public bool IsAuthorized(IIdentity user)
        {
            if (this.role == null)
                return this.IsIdentityPresent(user);

            return this.IsIdentityInRole(user);
        }
    }
}