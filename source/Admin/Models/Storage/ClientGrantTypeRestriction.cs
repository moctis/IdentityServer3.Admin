﻿namespace Thinktecture.IdentityServer3.Admin.Models.Storage
{
    public class ClientGrantTypeRestriction
    {
        public virtual int Id { get; set; }
        public virtual string GrantType { get; set; }
        public virtual Client Client { get; set; }
    }
}
