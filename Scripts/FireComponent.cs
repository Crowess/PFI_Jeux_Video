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
    AudioSource audioShotgun;

    Ray ray;
    public int pointage = 0;
    public string status;
    private int point = 1;
    private int streak = 1;

    [SerializeField] Animator animator;
    PlayerControls playerControls;
    void Awake()
    {
        audioShotgun = GetComponent<AudioSource>();
        playerControls = new PlayerControls();
        playerControls.Enable();
        playerControls.PC.Fire.performed += (ctx) =>
        {
            ray = new Ray(exitLocation.position, exitLocation.forward);
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
                    ResetStreak();
                }
            }
            // s'il hit rien
            else
            {
                ResetStreak();
            }

            audioShotgun.Play();
            animator.SetTrigger("Fire");
        };
        
    }
    public void ResetStreak(string raison = "Missed! Streak lost...")
    {
        status = raison;
        streak = 1;
    }
}
