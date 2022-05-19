using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingComponent : MonoBehaviour
{
    Canvas setting;
    [SerializeField] Canvas confirmation;
    [SerializeField] Canvas mainMenu;
    [SerializeField] Slider sliderDifficulty;
    [SerializeField] Slider sliderSensitivity;

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
        PlayerPrefs.SetFloat("Sensitivity", sliderSensitivity.value);
        PlayerPrefs.SetFloat("Difficulty", sliderDifficulty.value);
        PlayerPrefs.Save();
        Cancel();
        OpenMainMenu();
    }
    public void Cancel() => confirmation.gameObject.SetActive(false);
    public void Apply() => confirmation.gameObject.SetActive(true);
}
