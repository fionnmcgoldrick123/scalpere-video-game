using NUnit.Framework.Constraints;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public static MoneyManager Instance { get; private set; }

    [SerializeField] private MoneyUIManager moneyUIManager;

    private static int currentMoney = 0;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    private void Start()
    {
        currentMoney = 0;
    }
    public static void AssignMoney(int ballValue)
    {
        Debug.Log("MONEY EARNED: " + ballValue);
        currentMoney += ballValue;
        MoneyUIManager.Instance.UpdateMoneyUI(ballValue);
    }

}
