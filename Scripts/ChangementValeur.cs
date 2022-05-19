using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangementValeur : MonoBehaviour
{
    [SerializeField] string information;
    Slider sliderSelected;
    [SerializeField] Text displayValue;

    private void Awake()
    {
        sliderSelected = GetComponent<Slider>();
    }
    public void displayDiffulty()
    {
        displayValue.text =  information + " : " + sliderSelected.value;
    }
}
