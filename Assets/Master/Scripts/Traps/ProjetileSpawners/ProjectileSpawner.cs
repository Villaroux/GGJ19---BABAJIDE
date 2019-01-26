using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    public GameObject projetilePreFab;
    
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
    public Direction dir;

    Vector2 direction;
    // Start is called before the first frame update
    private void Awake()
    {
        switch(dir)
        {
            case (Direction.Left):
                direction = -Vector2.right;
                break;
            case (Direction.Right):
                direction = Vector2.right;
                break;
            case (Direction.Up):
                direction = Vector2.up;
                break;
            case (Direction.Down):
                direction = -Vector2.up;
                break;
        }
    }
    private void Start()
    {
        SpawnArrow();
    }

    void SpawnArrow()
    {
        var instantiatePreFab = Instantiate(projetilePreFab, transform.position, Quaternion.identity);

        Projetile projetile = instantiatePreFab.GetComponent<Projetile>();

        if(projetile !=null)
        {
            projetile.Direction = direction;
        }
    }


}
