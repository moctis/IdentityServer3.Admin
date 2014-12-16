﻿using Owin;
using Thinktecture.IdentityServer.v3.Admin.EntityFramework;
using Thinktecture.IdentityServer.v3.Admin.Storage;
using Thinktecture.IdentityServer.v3.Admin.WebApi;

namespace Thinktecture.IdentityServer.v3.Admin.Host
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var options = CreateStorageOptions();
            app.UseThinktectureIdentityServerAdmin(options);
        }

        private StorageOptions CreateStorageOptions()
        {
            var options = new StorageOptions();
            options.StorageRegistrations = new AdminEntityFrameworkStorageRegistrations("IdentityServer");

            return options;
        }
    }
}