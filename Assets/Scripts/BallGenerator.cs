using System;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;
using UnityEngine.UIElements;

public class BallGenerator : MonoBehaviour
{
    [SerializeField] ScreenManager2D backgroundScalar;
    [SerializeField] GameObject[] balls;
    

    private float screenWidth;
    private float screenHeight;
    private const float bottomOffset = -5f;

    [Header("Ball Spawning Control Center")]
    [SerializeField] float minHeight = 0f;
    [SerializeField] float maxHeight = 0f;
    [SerializeField] float directionClamp = 2f;

    [SerializeField] float edgeOffset = 0f;


    void Start()
    {
        float screenWidth = backgroundScalar.GetWidth();
        float screenHeight = backgroundScalar.GetHeight();


    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBall(balls[UnityEngine.Random.Range(0, balls.Length)]);
        }
    }

    void SpawnBall(GameObject ball)
    {
        GameObject ballPrefab = Instantiate(ball);

        float xPos = RandomWidthPosition();

        ballPrefab.transform.position = new Vector3(xPos, screenHeight + bottomOffset, 0f);

        Rigidbody rb = ballPrefab.GetComponent<Rigidbody>();

        if (rb != null)
        {
            float upForce = UnityEngine.Random.Range(minHeight, maxHeight);
            float sideForce = UnityEngine.Random.Range(-directionClamp, directionClamp);

            Vector3 force = new Vector3(sideForce, upForce, 0f);

            rb.AddForce(force, ForceMode.Impulse);

            rb.AddTorque(UnityEngine.Random.insideUnitSphere * 4f, ForceMode.Impulse);
        }


    }

    private float RandomWidthPosition()
    {
        return UnityEngine.Random.Range(backgroundScalar.getLeftScreen() + edgeOffset, backgroundScalar.getRightScreen() - edgeOffset);
    }
}
