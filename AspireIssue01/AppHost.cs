using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var project = builder.AddProject<WebApplication1>("webapp1");

builder.Build().Run();