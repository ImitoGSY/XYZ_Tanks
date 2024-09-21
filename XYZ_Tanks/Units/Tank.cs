﻿using XYZ_Tanks.Engine;
using Microsoft.Extensions.DependencyInjection;


namespace XYZ_Tanks.Units;
public class Tank
{
    public Transform Transform { get; } = new Transform();

    public int Health { get; set; } = 2;

    public void MoveUp()
    {
        Transform.Position = Transform.Upper;
    }

    public void MoveDown()
    {
        Transform.Position = Transform.Lower;
    }

    public void MoveLeft()
    {
        Transform.Position = Transform.Lefter;
    }

    public void MoveRight()
    {
        Transform.Position = Transform.Righter;
    }
}
