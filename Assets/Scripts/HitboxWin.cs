using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxWin : MonoBehaviour
{
    
    [SerializeField] private GameObject WinUI;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            WinUI.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
