using UnityEngine;

public class ActivateBlock : MonoBehaviour
{
    public GameObject TOTEMGO;
    public GameObject Spritemask;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController player = collision.GetComponent<PlayerController>();

        if (player != null)
        {
            Spritemask.transform.localScale *= 2.0f;
            gameObject.SetActive(false);
            TOTEMGO.SetActive(true);
        }
    }
}
