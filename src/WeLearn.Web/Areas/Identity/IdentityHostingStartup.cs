﻿using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(WeLearn.Web.Areas.Identity.IdentityHostingStartup))]
namespace WeLearn.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {});
        }
    }
}