using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePointageComponent : MonoBehaviour
{
    [SerializeField] FireComponent tir;
    Text points;
    // Start is called before the first frame update
    void Start()
    {
        points = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        points.text = tir.pointage.ToString();
    }
}
