using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    [SerializeField] Image[] hearts;
    private int playerLives;

    private void Start()
    {
        playerLives = 3;
    }

    public void LoseHeart(int damage)
    {
        hearts[playerLives - 1].color = Color.gray;
        playerLives -= damage;
        CheckDeath();
    }

    private void CheckDeath()
    {

        //TODO: Use a death state

        if(playerLives <= 0)
        {
            Debug.Log("YOU DIED!");
        }
    }
}
