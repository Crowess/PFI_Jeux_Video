using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngameMenuComponent : MonoBehaviour
{
    [SerializeField] Canvas menu;
    [SerializeField] FirstPersonCamera fpCamera;
    PlayerControls playerControls;
    void Awake()
    {
        playerControls = new PlayerControls();
        playerControls.PC.Menu.Enable();
        playerControls.PC.Menu.performed += Menu_performed;
    }

    private void Menu_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        if (menu.gameObject.activeSelf)
        {
            menu.gameObject.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            menu.gameObject.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
            
    }

    void Update()
    {
        
    }
}
