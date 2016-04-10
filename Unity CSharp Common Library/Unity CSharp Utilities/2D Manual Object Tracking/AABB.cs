using UnityEngine;

/// <summary>
/// Contains info about the AABB of a TrackedObjectData.
/// </summary>
public class AABB
{
    public Vector2 Center
    {
        get; private set;
    }

    public Vector2 Extents
    {
        get; private set;
    }

    public Vector2 Max
    {
        get
        {
            return Center + Extents;
        }
    }

    public Vector2 Min
    {
        get
        {
            return Center - Extents;
        }
    }

    public void Update(Bounds bounds)
    {
        Center = bounds.center.ToVector2();
        Extents = bounds.extents.ToVector2();
    }
}