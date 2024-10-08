﻿using XYZ_Tanks.Engine;


namespace XYZ_Tanks.Map;

public class RedrawRequiredAtArgs
{
    public RedrawRequiredAtArgs(Vector2Int position, RedrawType redrawType)
    {
        Position = position;
        RedrawType = redrawType;
    }

    public RedrawType RedrawType { get; }

    public Vector2Int Position { get; }
}
