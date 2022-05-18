using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingComponent : MonoBehaviour
{
    Canvas setting;
    [SerializeField] Canvas confirmation;
    [SerializeField] Canvas mainMenu;
    [SerializeField] InputField inputName;
    [SerializeField] Slider sliderDifficulty;

    void Awake()
    {
        setting = GetComponent<Canvas>();
    }

    public void OpenMainMenu()
    {
        setting.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(true);
    }

    public void Confirm()
    {
        //TODO PLAYER PREF
        PlayerPrefs.SetString("PlayerName", !string.IsNullOrEmpty(inputName.text)? inputName.text : "Default" );
        PlayerPrefs.SetFloat("Difficulty", sliderDifficulty.value);
        PlayerPrefs.Save();
        Cancel();
        OpenMainMenu();
    }
    public void Cancel() => confirmation.gameObject.SetActive(false);
    public void Apply() => confirmation.gameObject.SetActive(true);
}
