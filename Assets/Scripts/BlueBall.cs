using UnityEngine;

public class BlueBall : MonoBehaviour, IBall
{
    Color ballColor = Color.cyan;

    private void Start()
    {
        GetComponent<Renderer>().material.SetColor("_BaseColor", ballColor);
    }

    public void move()
    {
        Debug.Log("moves");
    }

    public void die()
    {
        Debug.Log("die");
    }
}
