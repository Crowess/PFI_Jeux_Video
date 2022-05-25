using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateStatusComponent : MonoBehaviour
{
    [SerializeField] FireComponent tir;
    Text status;
    // Start is called before the first frame update
    void Start()
    {
        status = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        status.text = tir.status.ToString();
    }
}
