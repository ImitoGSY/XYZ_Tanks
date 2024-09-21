namespace XYZ_Tanks.Engine;
using Microsoft.Extensions.DependencyInjection;


public interface IUpdateable
{
    void Update(double deltaSeconds);
}