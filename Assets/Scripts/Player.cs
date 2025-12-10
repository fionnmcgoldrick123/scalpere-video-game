using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] MoneySFXManager moneySFXManager;
    [SerializeField] HealthManager healthManager;

    private void Update()
    {
        CheckForCollisions();

        if (Input.GetKeyDown(KeyCode.R))
        {
            healthManager.LoseHeart(1);
        }
    }

    private void CheckForCollisions()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                HandleCollision(hit);
            }
        }
    }

    private void HandleCollision(RaycastHit hit)
    {
        Debug.Log("Hit: " + hit.collider.name);
        moneySFXManager.PlayMoneyBag();

        IBall ball = hit.collider.GetComponent<IBall>();
        MoneyManager.AssignMoney(ball.GetValue());
        MoneyUIManager.Instance.DisplayOnScreenMoneyUI(ball.GetValue(), hit.collider.transform.position);

        Destroy(hit.collider.gameObject);
    }


}
