using UnityEngine;

public class Circle : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Rigidbody2D rb;

    public float size; 
    public float launchForce;
    public float baseSpeed;

    public int health;

    public int scoreValue;

    public LocationType locationType;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void Initialize(CircleData data)
    {
        size = data.size;
        launchForce = data.launchForce;
        baseSpeed = data.baseSpeed;
        health = data.health;
        scoreValue = data.scoreValue;
        transform.localScale = Vector3.one * size;
    }


}
