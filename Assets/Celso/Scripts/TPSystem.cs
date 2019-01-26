using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPSystem : MonoBehaviour
{

    //public Transform placeFrom; //Where we hit the TP/Stairs/Holes
    public Transform placeTo; //Where we go to

    private BoxCollider2D coll; //Collider of TP/Stairs/Hole

    private void Start()
    {
        coll = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        HyperTag tag = collision.GetComponent<HyperTag>();

        if (tag == null) return;

        if (tag.GetTag() == HyperTag.Tag.Player)
        {
            TPPControl move = collision.GetComponent<TPPControl>();
            move.TPTo(placeTo);
        }
    }
}
