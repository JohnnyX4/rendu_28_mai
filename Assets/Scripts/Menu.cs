using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject PauseMenuUI;
    private Controls controls;
    private static bool gamePaused = false;

    private void OnEnable()
    {
        controls = new Controls();
        controls.Enable();
        controls.Main.Pause.performed += PausePerformed;
    }

    private void PausePerformed(InputAction.CallbackContext obj)
    {
        if (gamePaused)
        {
            Resume();
        }
        else
        {
            Paused();
        }
    }

    private void Paused()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        gamePaused = true;
    }

    private void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        gamePaused = false;
    }

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
