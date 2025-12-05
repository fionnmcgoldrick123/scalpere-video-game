using Unity.VisualScripting;
using UnityEngine;

public class BackgroundScaler : MonoBehaviour
{
    void Start()
    {
        //TODO: Fix the height scaling ERROR without using this magic variable
        float magicHeightFix = 2f;

        Camera cam = Camera.main;

        float height = cam.orthographicSize * 2;
        float width = height * Screen.width / Screen.height;

        transform.localScale = new Vector3(width, height + magicHeightFix, 1);  
    }
}
