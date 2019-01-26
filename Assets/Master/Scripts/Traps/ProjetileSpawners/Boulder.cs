using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Boulder : Projetile
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

        if (player != null)
        {
            Debug.Log("DieSquasdasda");
        }
    }
}
