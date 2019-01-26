using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Arrow : Projetile
{
    Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = Direction * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController player = collision.GetComponent<PlayerController>();

        if(player != null)
        {
            Animator playeranim = player.GetComponent<Animator>();

            if(playeranim != null)
            {
                AnimatorStateInfo animState = playeranim.GetCurrentAnimatorStateInfo(0);

                if(animState.IsName("Block"))
                {
                    return;
                }
                else
                {
                    Debug.Log("Die Twice");
                }
            }
            else
            {
                Debug.Log("DIE");
            }
        }
    }
}
