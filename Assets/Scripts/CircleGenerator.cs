using UnityEngine;
using System.Collections.Generic;

public class CircleGenerator : MonoBehaviour
{
    public CircleData GenerateCircleData()
    {
        CircleData data = new CircleData
        {
            size = Random.Range(0.5f, 1.5f),
            launchForce = Random.Range(5f, 15f),
            baseSpeed = Random.Range(1f, 5f),
            health = Random.Range(1, 5),
            scoreValue = Random.Range(10, 50),
            abilityType = new List<AbilityType> { AbilityType.None }, // Placeholder for abilities
            locationType = LocationType.Base // Placeholder for location type
        };

        return data;
    }
}
