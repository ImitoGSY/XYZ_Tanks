namespace XYZ_Tanks.Input;
using Microsoft.Extensions.DependencyInjection;

public class InputEventArgs : EventArgs
{
    public InputEventArgs(InputAction inputAction)
    {
        InputAction = inputAction;
    }

    public InputAction InputAction { get; }
}
