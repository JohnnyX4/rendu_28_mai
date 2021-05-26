using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxKill : MonoBehaviour
{
    [SerializeField] Transform SpawnPoint;                                   //On récupère le transform du point de respawn

    private void OnCollisionStay2D(Collision2D collision)                    //On détecte quand il y a une collision prolongée
    {
        if (collision.transform.CompareTag("Player"))                        //Si il y a collision avec un objet possédant le tag Player
            collision.transform.position = SpawnPoint.position;              //On récupère la position du transform de resapwn et on y téléporte l'objet Player
    }
}
