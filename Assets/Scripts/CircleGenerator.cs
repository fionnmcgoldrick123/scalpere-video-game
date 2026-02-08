using UnityEngine;
using System.Collections.Generic;

public class CircleGenerator : MonoBehaviour
{

    public GameObject circlePrefab;
    public CircleData GenerateCircleData()
    {

        // TODO: Add dificulty scaling and more complex logic for generating circle data based on game progression, player performance, etc.

        CircleData data = new CircleData
        {
            size = Random.Range(0.5f, 1.5f),
            launchForce = Random.Range(8f, 11.5f),
            baseSpeed = Random.Range(1f, 5f),
            health = Random.Range(1, 5),
            scoreValue = Random.Range(10, 50),
            abilityType = new List<AbilityType> { AbilityType.None }, // Placeholder for abilities
            locationType = LocationType.Base // Placeholder for location type
        };

        return data;
    }

    public void SpawnCircle()
    {
        CircleData data = GenerateCircleData();
        GameObject circleObject = Instantiate(circlePrefab, Vector3.zero, Quaternion.identity);
        Circle circle = circleObject.GetComponent<Circle>();
        circle.Initialize(data);
        LaunchCircle(circle);
    }

    public void LaunchCircle(Circle circle)
    {
        Vector3 spawnPosition = LocationData.GetLocation(circle.locationType);
        circle.transform.position = spawnPosition;

        // Calculate launch direction based on location type
        Vector2 launchDirection = Vector2.zero;
        switch (circle.locationType)
        {
            case LocationType.Base:
                launchDirection = Vector2.up + new Vector2(Random.Range(-0.3f, 0.3f), 0); // Upwards with some horizontal variation
                break;
            case LocationType.Inverse:
                launchDirection = Vector2.down;
                break;
            case LocationType.Commet:
                launchDirection = (spawnPosition.x < 0) ? Vector2.right : Vector2.left;
                break;
            case LocationType.Void:
                launchDirection = Random.insideUnitCircle.normalized; // Random direction for void
                break;
        }

        circle.GetComponent<Rigidbody2D>().AddForce(launchDirection * circle.launchForce, ForceMode2D.Impulse);
    }



}
