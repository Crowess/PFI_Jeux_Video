using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
// Sprite animation 2d https://learn.unity.com/tutorial/introduction-to-sprite-animations
// pour comprendre les triggers https://docs.unity3d.com/ScriptReference/Animator.SetTrigger.html

public class Fire : MonoBehaviour
{
    [SerializeField] Animator animator;
    PlayerControls playerControls;
    void Awake()
    {
        playerControls = new PlayerControls();
        playerControls.Enable();
        playerControls.PC.Fire.performed += (ctx) =>
        {
            //Rajouter le code pour raycasting 
            animator.SetTrigger("Fire");
        };
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
