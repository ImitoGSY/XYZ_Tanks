using XYZ_Tanks.Engine;
using Microsoft.Extensions.DependencyInjection;


namespace XYZ_Tanks.Extensions;
public static class RandomExtensions
{
    public static Vector2Int Next(this Random random, int maxX, int maxY) =>
        new(random.Next(maxX), random.Next(maxY));
}
