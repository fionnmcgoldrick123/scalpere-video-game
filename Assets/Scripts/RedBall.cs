using Unity.VisualScripting;
using UnityEngine;

public class RedBall : MonoBehaviour, IBall 
{

    Color ballColor = Color.red;

    private const int value = 15;

    private void Start()
    {
        GetComponent<Renderer>().material.SetColor("_BaseColor", ballColor);
    }
    public void Move()
    {
        Debug.Log("moves");
    }

    public void Die()
    {
        Debug.Log("die");
    }

    public int GetValue()
    {
        return value;
    }
}
