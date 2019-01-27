using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    public ProjectileSpawner[] pS;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(pS.Length > 0)
        {
            foreach(var spawner in pS)
            {
                spawner.SpawnProjectile();
            }

        }
        gameObject.SetActive(false);
    }
}
