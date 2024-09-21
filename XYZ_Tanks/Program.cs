using XYZ_Tanks;
using XYZ_Tanks.Engine;
using Microsoft.Extensions.DependencyInjection;


var serviceProvider = new ServiceCollection()
    .AddGame()
    .BuildServiceProvider();

var game = serviceProvider.GetRequiredService<Game>();
await game.RunAsync();