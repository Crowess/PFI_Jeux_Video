using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingBarComponent : MonoBehaviour
{
    Image loadingBar;
    float progession = 0;
    [SerializeField] float tempsLoading = 5;
    void Start()
    {
        loadingBar = GetComponent<Image>();
        loadingBar.fillAmount = progession;
        StartCoroutine("LoadScene");
    }
    IEnumerator LoadScene()
    {
        AsyncOperation loading = SceneManager.LoadSceneAsync("Game");
        loading.allowSceneActivation = false;
       
        while(progession < 1)
        {
            loadingBar.fillAmount = progession;
            progession += 1 / tempsLoading;
            yield return new WaitForSeconds(1);
        }
        loading.allowSceneActivation = true; 

        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
