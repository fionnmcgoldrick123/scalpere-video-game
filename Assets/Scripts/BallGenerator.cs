using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;

public class BallGenerator : MonoBehaviour
{
    [SerializeField] BackgroundScaler backgroundScalar;
    [SerializeField] RedBall redBall;
    float screenWidth;
    float screenHeight;

    private const float bottomOffset = -8;
    void Start()
    {
        float screenWidth = backgroundScalar.getWidth();
        float screenHeight = backgroundScalar.getHeight();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spawnBall(redBall);
        }
    }

    void spawnBall(Ball ball)
    {
        // Needs randomwidth position
        // if position is more left or right, change direction ball thrown
        // getting ball speed
        // getting ball arch / trajectory
        
        float xPos = randomWidthPos();
        
        var ballMono = ball as MonoBehaviour;
        ballMono.transform.position = new Vector3(xPos, screenHeight + bottomOffset, 0);


    }

    private float randomWidthPos()
    {
        return UnityEngine.Random.Range(backgroundScalar.getLeftScreen(), backgroundScalar.getRightScreen());
    }
}
