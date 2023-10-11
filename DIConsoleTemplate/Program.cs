using DIConsoleTemplate;
using DIConsoleTemplate.Interfaces;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

// Add all services to DI
services.AddSingleton<IRunner, ConsoleRunner>();


var provider = services.BuildServiceProvider();

// Resolve the configured runner from the DI
var runner = provider.GetService<IRunner>();
ArgumentNullException.ThrowIfNull(runner);

runner.Run(args);