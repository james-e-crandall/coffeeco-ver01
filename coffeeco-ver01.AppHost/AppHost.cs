using Microsoft.Extensions.Hosting;

var builder = DistributedApplication.CreateBuilder(args);

var bff = builder.AddProject<Projects.CoffeeCo_Bff>("bff")
    .WithHttpHealthCheck("/health");



if (builder.Environment.IsDevelopment())
{
    var sqlUIConfig = builder.AddSqlServer("sqlUIConfig")
    .WithDataVolume();
    
    var sqldbUIConfig = sqlUIConfig.AddDatabase("sqldbUIConfig");
    var migrationService = builder.AddProject<Projects.CoffeeCo_UI_MigrServSqlServer>("migrationService")
        .WithReference(sqldbUIConfig)
        .WaitFor(sqldbUIConfig);

    var uiapi = builder.AddProject<Projects.CoffeeCo_UIApi>("uiapi")
        .WithExternalHttpEndpoints()
        .WithHttpHealthCheck("/health")
        .WithReference(migrationService)
        .WaitForCompletion(migrationService)
        .WithReference(sqldbUIConfig)
        .WaitFor(sqldbUIConfig);

    bff.WithReference(uiapi);

}
else
{
    // Add production-ready services
    var sqlUIConfig = builder.AddSqlServer("sqlUIConfig")
    .WithDataVolume();
    
    var sqldbUIConfig = sqlUIConfig.AddDatabase("sqldbUIConfig");
    var migrationService = builder.AddProject<Projects.CoffeeCo_UI_MigrServSqlServer>("migrationService")
        .WithReference(sqldbUIConfig)
        .WaitFor(sqldbUIConfig);

    var uiapi = builder.AddProject<Projects.CoffeeCo_UIApi>("uiapi")
        .WithExternalHttpEndpoints()
        .WithHttpHealthCheck("/health")
        .WithReference(migrationService)
        .WaitForCompletion(migrationService)
        .WithReference(sqldbUIConfig)
        .WaitFor(sqldbUIConfig);

    bff.WithReference(uiapi);
}


#pragma warning disable ASPIRECERTIFICATES001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.

var coffeecompanywebsite = builder.AddJavaScriptApp("coffeecowebsite", "../coffeeco-website", runScriptName: "start")
    .WithHttpEndpoint(env: "PORT")
    .WithExternalHttpEndpoints()
    .PublishAsDockerFile()
    .WithReference(bff)
    .WaitFor(bff);

#pragma warning restore ASPIRECERTIFICATES001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.


builder.Build().Run();
