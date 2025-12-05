using Unity.VisualScripting;
using UnityEngine;

public class BackgroundScaler : MonoBehaviour
{

    private float width;
    private float height;
    Camera cam;
    void Awake()
    {
        //TODO: Fix the height scaling ERROR without using this magic variable
        float magicHeightFix = 2f;

        cam = Camera.main;

        height = cam.orthographicSize * 2;
        width = height * Screen.width / Screen.height;
        //Debug.Log("Bgs width: " + width + "Bgs height: " + height);

        transform.localScale = new Vector3(width, height + magicHeightFix, 1);
    }

    public float getWidth()
    {
        return width;
    }

    public float getHeight()
    {
        return height;
    }

    public float getLeftScreen()
    {
        return cam.ViewportToWorldPoint(new Vector3(0, 0, cam.nearClipPlane)).x;
    }

    public float getRightScreen()
    {
        return cam.ViewportToWorldPoint(new Vector3(1, 0, cam.nearClipPlane)).x;
    }

}
