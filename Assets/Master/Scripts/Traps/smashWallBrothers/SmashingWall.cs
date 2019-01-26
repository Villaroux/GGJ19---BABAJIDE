using UnityEngine;

public class SmashingWall : Trap
{
    public BoxCollider2D LeftWall, RightWall;

    [SerializeField]
    LayerMask playerMask;

    [SerializeField]
    float xLenght;
    [SerializeField]
    float yLenght;
    private void Update()
    {
        RaycastHit2D leftHit = Physics2D.BoxCast(LeftWall.transform.position, new Vector2(LeftWall.transform.position.x + xLenght, LeftWall.transform.position.y + yLenght) , 180.0f, Vector2.right, playerMask);
        RaycastHit2D rightHit = Physics2D.BoxCast(RightWall.transform.position, new Vector2(RightWall.transform.position.x + xLenght, RightWall.transform.position.y + yLenght), 180.0f, -Vector2.right, playerMask);

        Debug.DrawLine(LeftWall.transform.position, new Vector2(LeftWall.transform.position.x + xLenght, LeftWall.transform.position.y + yLenght));
        Debug.DrawLine(RightWall.transform.position, new Vector2(RightWall.transform.position.x + xLenght, RightWall.transform.position.y + yLenght));


        if (leftHit && rightHit)
        {
            Debug.Log("Hit player");
        }
    }

}
