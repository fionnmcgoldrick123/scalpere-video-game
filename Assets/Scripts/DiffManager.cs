using UnityEngine;

public class DiffManager : MonoBehaviour
{

    public CircleGenerator circleGenerator;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            circleGenerator.SpawnCircle();
        }
    }


}
