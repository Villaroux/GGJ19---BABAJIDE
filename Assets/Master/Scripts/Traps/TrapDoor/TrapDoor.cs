using UnityEngine;

public class TrapDoor : MonoBehaviour
{
    Animator animCtrl;
    [SerializeField]
    LayerMask playerMask;

    [SerializeField]
    float xLenght;
    [SerializeField]
    float yLenght;
    private void Awake()
    {
        animCtrl = GetComponent<Animator>();
    }
    private void Update()
    {
        AnimatorStateInfo currState = animCtrl.GetCurrentAnimatorStateInfo(0);

        if (currState.IsName("TrapDoorOpened"))
        {
            if (Physics2D.OverlapBox(transform.position, new Vector2(xLenght, yLenght), 0.0f, playerMask))
            {
                Debug.Log("DEADEADEAD");
            }
        }

        Debug.DrawLine(transform.position, new Vector2(xLenght, yLenght));
    }
}
