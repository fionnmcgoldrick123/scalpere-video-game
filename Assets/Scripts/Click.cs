using UnityEngine;

public class Click : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0f;
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null)
            {
                Circle circle = hit.collider.GetComponent<Circle>();
                if (circle != null)
                {
                    // Handle circle click logic here
                    Debug.Log("Circle clicked! Score: " + circle.scoreValue);
                    // You can also call a method to reduce health or destroy the circle
                }
            }
        }


    }
}
