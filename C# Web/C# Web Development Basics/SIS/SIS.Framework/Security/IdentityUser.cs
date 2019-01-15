namespace SIS.Framework.Security
{
    using System;

    using Base;

    public class IdentityUser : IdentityUser<string>
    {
        public IdentityUser()
        {
            base.Id = Guid.NewGuid().ToString();
        }
    }
}