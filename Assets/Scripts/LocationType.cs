using System.Collections.Generic;
using UnityEngine;

public enum LocationType
{
    Base,
    Inverse,

    Commet,

    Void
}

public static class LocationData
{
    private static readonly Dictionary<LocationType, UnityEngine.Vector3> locations = new Dictionary<LocationType, Vector3>
    {
        { LocationType.Base, new UnityEngine.Vector3(0, 0, 0) },
        { LocationType.Inverse, new UnityEngine.Vector3(10, 0, 0) },
        { LocationType.Commet, new UnityEngine.Vector3(20, 0, 0) },
        { LocationType.Void, new UnityEngine.Vector3(30, 0, 0) }
    };

    public static Vector3 GetLocation(LocationType type)
    {
        return locations[type];
    }

    //Usage example:
    //Vector3 spawnPos = LocationData.GetPosition(LocationType.SpawnPointLeft);
}

