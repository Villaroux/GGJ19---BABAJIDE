using UnityEngine;

public class ActivateDash : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController player = collision.GetComponent<PlayerController>();

        if(player != null)
        {
            player.IsDashActivated = true;
        }
    }
}
