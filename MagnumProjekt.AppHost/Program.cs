var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.MagnumApp>("magnumapp");

builder.AddProject<Projects.Magnum_Api>("magnum-api");

builder.Build().Run();
