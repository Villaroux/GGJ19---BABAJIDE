using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateExtraMoveSpeed : MonoBehaviour
{
    public GameObject TOTEMGO;
    [SerializeField]
    float newMoveSpeed = 20.0f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController player = collision.GetComponent<PlayerController>();

        if (player != null)
        {
            player.speed = newMoveSpeed;
            gameObject.SetActive(false);
            TOTEMGO.SetActive(true);
        }
    }
}
