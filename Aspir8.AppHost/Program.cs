var builder = DistributedApplication.CreateBuilder(args);

var api = builder
    .AddProject<Projects.Aspir8_ApiService>("api");

builder.AddContainer("apiContainer", "mcr.microsoft.com/dotnet/aspnet:5.0")
    .WithDockerfile(".")
    .WithReference(api);

builder.Build().Run();
