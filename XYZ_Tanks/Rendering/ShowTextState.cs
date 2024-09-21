namespace XYZ_Tanks.Rendering;
using Microsoft.Extensions.DependencyInjection;

internal class ShowTextState
{
    public void RenderGameOverScreen(bool win)
    {
        Console.Clear();
        if (win)
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("Game Over!");
        }
    }
}
