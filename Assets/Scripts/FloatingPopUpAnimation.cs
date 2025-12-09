using UnityEngine;
using TMPro;

public class FloatingPopUpAnimation : MonoBehaviour
{
    private TextMeshProUGUI text;

    [Header("Animation Times")]
    [SerializeField] private float lifetime = 0.8f;
    [SerializeField] private float moveSpeed = 40f;
    [SerializeField] private float startScale = 0.6f;
    [SerializeField] private float endScale = 1.2f;
    [SerializeField] private float scaleTime = 0.15f;

    private float scaleTimer = 0f;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
        transform.localScale = Vector3.one * startScale;
    }

    private void Update()
    {
        if (scaleTimer < scaleTime)
        {
            scaleTimer += Time.deltaTime;
            float t = scaleTimer / scaleTime;
            transform.localScale = Vector3.Lerp(Vector3.one * startScale, Vector3.one * endScale, t);
        }

        transform.position += Vector3.up * moveSpeed * Time.deltaTime;

        lifetime -= Time.deltaTime;
        text.alpha = lifetime / 0.8f;   

        if (lifetime <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
