using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
// Sprite animation 2d https://learn.unity.com/tutorial/introduction-to-sprite-animations
// pour comprendre les triggers https://docs.unity3d.com/ScriptReference/Animator.SetTrigger.html

public class FireComponent : MonoBehaviour
{
    [SerializeField] Transform exitLocation;
    Ray ray;

    [SerializeField] Animator animator;
    PlayerControls playerControls;
    void Awake()
    {
        playerControls = new PlayerControls();
        playerControls.Enable();
        playerControls.PC.Fire.performed += (ctx) =>
        {
            ray = new Ray(exitLocation.position, exitLocation.forward);
            Debug.DrawRay(ray.origin, ray.direction, Color.black, 100f);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Contour" )
                {
                    hit.transform.parent.gameObject.SetActive(false);
                }
            }
            animator.SetTrigger("Fire");
        };
        
    }
    // Update is called once per frame
    void Update()
    {

    }
}
