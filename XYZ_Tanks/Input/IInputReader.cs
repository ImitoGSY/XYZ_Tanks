namespace XYZ_Tanks.Input;
using Microsoft.Extensions.DependencyInjection;

internal interface IInputReader
{
    event EventHandler<InputEventArgs> InputActionCalled;

    void Update();
}
