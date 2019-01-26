using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    ProjectileSpawner pS;
    private void Awake()
    {
        pS = GetComponentInParent<ProjectileSpawner>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController player = collision.GetComponentInParent<PlayerController>();

        if(player != null)
        {
            pS.SpawnProjectile();
        }
    }
}
