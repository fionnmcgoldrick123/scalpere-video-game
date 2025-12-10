using UnityEngine;

public class MoneySFXManager : MonoBehaviour
{
    [SerializeField] AudioSource moneyBag;

    [SerializeField] private float minRange = 1f;

    [SerializeField] private float maxRange = 1.3f;

    public void PlayMoneyBag()
    {
        moneyBag.pitch = GetRandomPitch();
        moneyBag.PlayOneShot(moneyBag.clip);
    }

    private float GetRandomPitch()
    {
        return Random.Range(minRange, maxRange);
    }
}
