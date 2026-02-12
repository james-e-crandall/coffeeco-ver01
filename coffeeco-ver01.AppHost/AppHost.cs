var builder = DistributedApplication.CreateBuilder(args);

var bff = builder.AddProject<Projects.CoffeeCo_Bff>("bff")
    .WithHttpHealthCheck("/health");

var uiapi = builder.AddProject<Projects.CoffeeCo_UIApi>("uiapi")
    .WithHttpHealthCheck("/health");

#pragma warning disable ASPIRECERTIFICATES001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.

var coffeecompanywebsite = builder.AddJavaScriptApp("coffeecowebsite", "../coffeeco-website", runScriptName: "start")
    .WithHttpEndpoint(env: "PORT")
    .WithExternalHttpEndpoints()
    .PublishAsDockerFile();

#pragma warning restore ASPIRECERTIFICATES001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.


builder.Build().Run();
