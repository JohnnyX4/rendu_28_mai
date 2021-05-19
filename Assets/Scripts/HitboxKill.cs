using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxKill : MonoBehaviour
{
    [SerializeField] Transform SpawnPoint;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
            collision.transform.position = SpawnPoint.position;
    }
}
