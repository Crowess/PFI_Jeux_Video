using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// Sprite animation 2d https://learn.unity.com/tutorial/introduction-to-sprite-animations
// pour comprendre les triggers https://docs.unity3d.com/ScriptReference/Animator.SetTrigger.html

public class FireComponent : MonoBehaviour
{
    [SerializeField] Transform exitLocation;
    AudioSource audio;

    Ray ray;
    public int pointage = 0;
    public string status;
    private int point = 1;
    private int streak = 1;

    [SerializeField] Animator animator;
    PlayerControls playerControls;
    void Awake()
    {
        audio = GetComponent<AudioSource>();
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
                    status = "Hit! + " + point * streak + " points!";
                    pointage += point * streak;
                    hit.transform.parent.GetComponent<TargetComponent>().AssociatedPool.PutObject(hit.transform.parent.gameObject);
                    hit.transform.parent.gameObject.SetActive(false);
                    streak++;
                }
                // s'il hit qqch d'autre qu'une cible
                else
                {
                    status = "Missed! Streak lost...";
                    streak = 1;
                }
            }
            // s'il hit rien
            else
            {
                status = "Missed! Streak lost...";
                streak = 1;
            }

            audio.Play();
            animator.SetTrigger("Fire");
        };
        
    }
    // Update is called once per frame
    void Update()
    {

    }
}
