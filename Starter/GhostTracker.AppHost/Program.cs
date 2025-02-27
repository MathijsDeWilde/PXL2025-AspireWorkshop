var builder = DistributedApplication.CreateBuilder(args);

var rabbitmq = builder.AddRabbitMQ("messaging")
    .WithManagementPlugin()
    .WithLifetime(ContainerLifetime.Persistent);

var manager = builder.AddProject<Projects.GhostTracker_GhostManager>("ghostmanagerapi")
    .WithReference(rabbitmq)
    .WaitFor(rabbitmq);
    var pathfinder = builder.AddProject<Projects.GhostTracker_PathFinderApi>("pathfinderapi")
    .WithReference(rabbitmq)
    .WaitFor(rabbitmq);

var bff = builder.AddProject<Projects.GhostTracker_Bff>("bff")
    .WithReference(manager)
    .WithReference(pathfinder);

// for (int i = 1; i < 6; i++)
// {
//     builder.AddProject<Projects.GhostTracker_Transmitter>($"transmitter-{i}")
//         .WithReference(manager)
//         .WithReference(pathfinder)
//         .WithEnvironment("GhostId", i.ToString());
// }

builder.AddProject<Projects.GhostTracker_Transmitter_RabbitMQ>("transmitter-rabbitmq");

builder.AddNpmApp("react", "../GhostTracker.React")
    .WithEnvironment("BROWSER", "none") // Disable opening browser on npm start
    .WithHttpEndpoint(env: "PORT")
    .WithReference(bff); // We will be forwarding a random port on which the frontend will run.

builder.Build().Run();