using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    Animator playeranime;

    [Header("Movement Settings")]
    public string MovementParameterName;
    public float speed = 2.0f;
    [Header("Dash Settings")]
    public KeyCode dashKey;
    [Range(0,1)]
    public float dashSpeedPercent = 5.0f;
    public float dashCD = 0.0f;
    float dashTimer;
    public bool IsDashActivated = false;
    bool dashTimerSetup = false;
    [Header("Block Settings")]
    public KeyCode blockKey;
    public string BlockParameterName;
    public bool IsBlockActivated = false;
    bool blockTimerSetup = true;
    public float blockCD = 0.0f;
    float blocktimer;

    public Transform recall;




    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playeranime = GetComponent<Animator>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //SetAnimator Velocity Parameters
        
        playeranime.SetFloat(MovementParameterName, rb.velocity.magnitude);
        //Ability Timer Methods
        DashTimer();
        BlockTimer();

        //Input
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        //Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);

        //transform.position = transform.position + movement * speed * Time.deltaTime;


        //Animation
        if(Input.GetKeyDown(blockKey))
        {
            playeranime.SetTrigger(BlockParameterName);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            transform.position = recall.position;
        }

        AnimatorStateInfo currState = playeranime.GetCurrentAnimatorStateInfo(0);

        if(!currState.IsName("Block"))
        {
            if (Input.GetKeyDown(dashKey) && Time.time - dashTimer > dashCD && IsDashActivated)
            {
                rb.velocity = movement.normalized * speed * (1.0f + dashSpeedPercent);
                dashTimerSetup = true;
            }
            else
            {
                //Commit
                rb.velocity = movement.normalized * speed;
            }
        }
    }
    void BlockTimer()
    {
        if (blockTimerSetup)
        {
            blocktimer = Time.time;
            blockTimerSetup = false;
        }
    }
    void DashTimer()
    {
        if (dashTimerSetup)
        {
            dashTimer = Time.time;
            dashTimerSetup = false;
        }
    }
}
