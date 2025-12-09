using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class BlueBall : MonoBehaviour, IBall
{
    Color ballColor = Color.cyan;

    private const int value = 10; 

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
