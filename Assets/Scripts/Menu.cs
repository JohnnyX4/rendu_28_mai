using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void play()
    {
        SceneManager.LoadScene("Platformer");
    }

    public void help()
    {
        SceneManager.LoadScene("Help");
    }

    public void credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void main()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
