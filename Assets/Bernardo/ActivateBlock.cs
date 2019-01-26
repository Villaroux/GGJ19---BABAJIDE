using UnityEngine;

public class ActivateBlock : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController player = collision.GetComponent<PlayerController>();

        if (player != null)
        {
            player.IsBlockActivated = true;
            gameObject.SetActive(false);
        }
    }
}
