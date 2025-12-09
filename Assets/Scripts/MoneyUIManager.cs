using TMPro;
using UnityEngine;

public class MoneyUIManager : MonoBehaviour
{
    public static MoneyUIManager Instance { get; private set; }

    [SerializeField] private TextMeshProUGUI moneyText;

    private int money;

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
        money = 0;
        moneyText.text = "0";
    }

    public void UpdateMoneyUI(int moneyScored)
    {
        money += moneyScored;
        moneyText.text = money.ToString();
    }

    public void DisplayOnScreenMoneyUI()
    {
        
    }
}
