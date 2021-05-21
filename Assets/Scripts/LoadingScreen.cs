using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{

    [SerializeField] GameObject loadingScreenPrefab;


    public void LoadSceneAsync()
    {
        StartCoroutine(LoadingScreenCoroutine());
    }
    private IEnumerator LoadingScreenCoroutine()
    {
        var prefab = Instantiate(loadingScreenPrefab);
        DontDestroyOnLoad(prefab);
        var sceneLoading = SceneManager.LoadSceneAsync("Platformer");
        sceneLoading.allowSceneActivation = false;
        while (sceneLoading.isDone == false)
        {
            if (sceneLoading.progress >= 0.9f)
            {
                sceneLoading.allowSceneActivation = true;
                prefab.GetComponent<Animator>().SetTrigger("disparaitre");
            }
            yield return new WaitForSeconds(1);
        }
    }
}
