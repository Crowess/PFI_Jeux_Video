using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastDemo : MonoBehaviour
{
    [SerializeField] Transform exitLocation;
    Ray ray;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ray = new Ray(exitLocation.position, exitLocation.forward);
        Debug.DrawRay(ray.origin, ray.direction, Color.black, 100f);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
            Debug.Log(hit.collider.name);
    }
}
