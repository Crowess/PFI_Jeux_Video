using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Avec l'aide de : https://answers.unity.com/questions/1331550/how-to-load-sprite-dynamically-from-assets-in-unit.html

public class UISetupComponent : MonoBehaviour
{
    [SerializeField] Image UiCrosshair;
    void Awake()
    {
        string crosshairName = !string.IsNullOrEmpty(PlayerPrefs.GetString("Crosshair")) ? PlayerPrefs.GetString("Crosshair") : "Crosshair_0"; //Met comme default Crosshair_0
        UiCrosshair.sprite = Resources.Load<Sprite>("Spites/"+crosshairName);
    }
}
