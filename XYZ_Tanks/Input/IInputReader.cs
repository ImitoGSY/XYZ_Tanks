namespace XYZ_Tanks.Input;

internal interface IInputReader
{
    event EventHandler<InputEventArgs> InputActionCalled;

    void Update();
}
