using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRotation : MonoBehaviour
{
    [SerializeField] GameObject cible;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.LookAt(cible.transform);
        gameObject.transform.Rotate(new Vector3(0,1,0));
    }
}
