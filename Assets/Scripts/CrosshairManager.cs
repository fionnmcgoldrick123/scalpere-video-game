using UnityEngine;

public class CrosshairManager : MonoBehaviour
{
    public Texture2D[] crosshairTextures;
    public int currentCrosshairIndex = 0;

    private Vector2 crosshairHotspot = Vector2.zero;
    void Start()
    {
        SetCrossHair(currentCrosshairIndex);
    }

    public void SetCrossHair(int index)
    {
        if (index >= 0 && index < crosshairTextures.Length)
        {
            Cursor.SetCursor(crosshairTextures[index], crosshairHotspot, CursorMode.Auto);
            currentCrosshairIndex = index;
        }
        else
        {
            Debug.LogWarning("Invalid crosshair index: " + index);
        }
    }

   
}
