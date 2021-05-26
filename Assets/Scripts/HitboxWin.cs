using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxWin : MonoBehaviour
{
    
    [SerializeField] private GameObject WinUI;                 //On récupère l'UI de victoire

    private void OnCollisionStay2D(Collision2D collision)      //On détecte quand il y a une collision prolongée
    {
        if (collision.transform.CompareTag("Player"))          //Si il y a collision avec un objet possédant le tag Player
        {
            WinUI.SetActive(true);                             //On active l'UI de victoire
            Time.timeScale = 0;                                //On arrête le temps pour stopper les mouvement du player
        }
    }
}
