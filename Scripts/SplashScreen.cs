using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class SplashScreen : MonoBehaviour
{
    AsyncOperation loading;
    Controles controls;
    void Awake()
    {
        controls = new Controles();
        controls.Keyboard.Enable();
        controls.Keyboard.KeyPressed.performed += KeyPressed_performed;

    }

    private void KeyPressed_performed(InputAction.CallbackContext obj)
    {
        PressToStart();
    }

    public void PressToStart()
    {
        controls.Keyboard.Disable();
        loading = SceneManager.LoadSceneAsync(1);
    }
   
}
