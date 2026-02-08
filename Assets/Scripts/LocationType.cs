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
    private const float edgeOffset = 0.5f;
    public static Vector3 GetLocation(LocationType type)
    {
        float camDistance = -Camera.main.transform.position.z;

        Vector3 bottomLeft = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, camDistance));
        Vector3 bottomRight = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, camDistance));
        Vector3 topLeft = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, camDistance));
        Vector3 topRight = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, camDistance));

        switch (type)
        {
            case LocationType.Base:
                float baseX = Random.Range(bottomLeft.x + edgeOffset, bottomRight.x - edgeOffset);
                float baseY = bottomLeft.y - edgeOffset;
                return new Vector3(baseX, baseY, 0f);

            case LocationType.Inverse:
                float inverseX = Random.Range(topLeft.x + edgeOffset, topRight.x - edgeOffset);
                float inverseY = topLeft.y + edgeOffset;
                return new Vector3(inverseX, inverseY, 0f);

            case LocationType.Commet:
                bool fromLeft = Random.value > 0.5f;
                float commetX = fromLeft
                    ? bottomLeft.x - edgeOffset
                    : bottomRight.x + edgeOffset;
                float commetY = Random.Range(bottomLeft.y + edgeOffset, topLeft.y - edgeOffset);
                return new Vector3(commetX, commetY, 0f);

            case LocationType.Void:
            default:
                return Vector3.zero;
        }
    }
}

