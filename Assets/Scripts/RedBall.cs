using Unity.VisualScripting;
using UnityEngine;

public class RedBall : MonoBehaviour, Ball 
{
    public void move()
    {
        Debug.Log("moves");
    }

    public void die()
    {
        Debug.Log("die");
    }
}
