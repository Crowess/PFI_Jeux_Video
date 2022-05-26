using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuComponent : MonoBehaviour
{
    [SerializeField] Canvas setting;
    Canvas mainMenu;
    [SerializeField]GameObject btnDevMode;
    void Awake()
    {
        PlayerPrefs.DeleteAll();
        mainMenu = GetComponent<Canvas>();
    }
    public void OpenSetting()
    {
        mainMenu.gameObject.SetActive(false);
        setting.gameObject.SetActive(true);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("loadingScene");
    }
   
}
