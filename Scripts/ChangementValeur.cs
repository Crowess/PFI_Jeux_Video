using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangementValeur : MonoBehaviour
{
    Slider sliderDifficulty;
    [SerializeField] Text displayDifficulty;

    private void Awake()
    {
        sliderDifficulty = GetComponent<Slider>();
    }
    public void displayDiffulty()
    {
        displayDifficulty.text = "Difficulty : "+sliderDifficulty.value;
    }
}
