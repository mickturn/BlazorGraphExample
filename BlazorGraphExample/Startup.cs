﻿using BlazorGraphExample.Services;
using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorGraphExample
{
    
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(new AppState());

            services.AddSingleton(new AuthConfig(
                clientId: "CLIENT ID HERE",
                scopes: new[] { "https://graph.microsoft.com/user.read https://graph.microsoft.com/files.read" }
                ));

            services.AddSingleton<IAuthService, AuthService>();
            services.AddSingleton<IGraphService, GraphService>();
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}