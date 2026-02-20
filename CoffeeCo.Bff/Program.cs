using CoffeeCo.Bff.Endpoints;
using Duende.Bff;
using Duende.Bff.DynamicFrontends;
using Duende.Bff.Yarp;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = BffAuthenticationSchemes.BffCookie;
    options.DefaultChallengeScheme = BffAuthenticationSchemes.BffOpenIdConnect;
    options.DefaultSignOutScheme = BffAuthenticationSchemes.BffOpenIdConnect;
});

builder.Services.AddBff()
    .AddRemoteApis()
    .ConfigureOpenIdConnect(options =>
    {
        options.Authority = "https://demo.duendesoftware.com";
        options.ClientId = "interactive.confidential";
        options.ClientSecret = "secret";
        options.ResponseType = "code";
        options.ResponseMode = "query";

        options.GetClaimsFromUserInfoEndpoint = true;
        options.MapInboundClaims = false;
        options.SaveTokens = true;

        options.Scope.Clear();
        options.Scope.Add("openid");
        options.Scope.Add("profile");
        options.Scope.Add("api");
        options.Scope.Add("offline_access");

        options.TokenValidationParameters = new()
        {
            NameClaimType = "name",
            RoleClaimType = "role"
        };
    })
    .ConfigureCookies(options =>
    {
        options.Cookie.Name = "__Host-bff";
        options.Cookie.SameSite = SameSiteMode.Strict;
    });

builder.Services.AddAuthorization();

var app = builder.Build();

app.UseDefaultFiles();
app.MapStaticAssets();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseBff();
app.UseAuthorization();
app.MapBffManagementEndpoints();

HealthEndpoints.RegisterEndpoints(app);

var uiapi = builder.Configuration.GetValue<string>("UIAPI_HTTP");
if(!string.IsNullOrEmpty(uiapi))
{
    app.Logger.LogInformation("Mapping remote BFF API endpoint to {UIAPI_HTTP}", uiapi);
    app.MapRemoteBffApiEndpoint("/uiapi", new Uri(uiapi));
}
else
{
    app.Logger.LogWarning("UIAPI_HTTP configuration value is not set. Remote BFF API endpoint will not be mapped.");
}

var storeapi = builder.Configuration.GetValue<string>("STOREAPI_HTTP");
if(!string.IsNullOrEmpty(uiapi))
{
    app.Logger.LogInformation("Mapping remote BFF API endpoint to {STOREAPI_HTTP}", storeapi);
    app.MapRemoteBffApiEndpoint("/storeapi", new Uri(uiapi));
}
else
{
    app.Logger.LogWarning("STOREAPI_HTTP configuration value is not set. Remote BFF API endpoint will not be mapped.");
}

app.MapFallbackToFile("/index.html");

app.Run();
