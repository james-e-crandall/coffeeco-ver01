using Microsoft.Extensions.Hosting;

var builder = DistributedApplication.CreateBuilder(args);

var bff = builder.AddProject<Projects.CoffeeCo_Bff>("bff")
    .WithHttpHealthCheck("/health");

    var uiapi = builder.AddProject<Projects.CoffeeCo_UIApi>("uiapi")
        .WithExternalHttpEndpoints()
        .WithHttpHealthCheck("/health");

    bff.WithReference(uiapi);

    var sqlUIConfig = builder.AddSqlServer("sqlUIConfig")
    .WithDataVolume();


    var sqldbUIConfig = sqlUIConfig.AddDatabase("sqldbUIConfig");
    var migrationServicesqlserver = builder.AddProject<Projects.CoffeeCo_UI_MigrServSqlServer>("migrationServicesqlserver")
        .WithReference(sqldbUIConfig)
        .WaitFor(sqldbUIConfig);

    uiapi.WithReference(migrationServicesqlserver)
        .WaitForCompletion(migrationServicesqlserver)
        .WithReference(sqldbUIConfig)
        .WaitFor(sqldbUIConfig);

    //  var postgres = builder.AddPostgres("postgres");
    // var postgresdb = postgres.AddDatabase("postgresdb");


    // var migrationServicepostgresql = builder.AddProject<Projects.CoffeeCo_UI_MigrServPostgresql>("migrationServicepostgresql")
    //     .WithReference(postgresdb)
    //     .WaitFor(postgresdb);

    // uiapi.WithReference(migrationServicepostgresql)
    //     .WaitForCompletion(migrationServicepostgresql)
    //     .WithReference(postgresdb)
    //     .WaitFor(postgresdb);  


#pragma warning disable ASPIRECERTIFICATES001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.

var coffeecompanywebsite = builder.AddJavaScriptApp("coffeecowebsite", "../coffeeco-website", runScriptName: "start")
    .WithHttpEndpoint(env: "PORT")
    .WithExternalHttpEndpoints()
    .PublishAsDockerFile()
    .WithReference(bff)
    .WaitFor(bff);

#pragma warning restore ASPIRECERTIFICATES001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.


builder.Build().Run();
