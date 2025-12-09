using NUnit.Framework.Constraints;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public static MoneyManager Instance { get; private set; }
    private float mult = 0f;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    public static void AssignMoney(int ballValue)
    {
        Debug.Log("MONEY EARNED: " + ballValue);
    }

    public static void ApplyMult()
    {
        //TODO: cool ideas with money mult
    }

}
