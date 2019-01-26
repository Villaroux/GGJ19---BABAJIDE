using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 2.0f;
    [Header("Dash Settings")]
    public KeyCode dashKey;
    public float dashSpeed = 5.0f;
    public float dashCD = 0.0f;
    float dashTimer;
    public bool IsDashActivated = false;
    bool dashTimerSetup = false;
    [Header("Block Settings")]
    public KeyCode blockKey;
    public bool IsBlockActivated = false;
    bool blockTimerSetup = true;
    public float blockCD = 0.0f;
    float blocktimer;




    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        DashTimer();
        BlockTimer();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);

        //Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);

        transform.position = transform.position + movement * speed * Time.deltaTime;


        if (Input.GetKeyDown(dashKey) &&  Time.time - dashTimer > dashCD)
        {
            transform.position = transform.position + movement * dashSpeed * Time.deltaTime;
            dashTimerSetup = true;
        }
    }
    void BlockTimer()
    {
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
