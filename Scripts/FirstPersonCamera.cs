using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonCamera : MonoBehaviour
{
    [SerializeField] Transform player;
    public float sensibility = 100;
    float verticalRotation = 0;
    // Start is called before the first frame update
    void Start()
    {
        sensibility = PlayerPrefs.GetFloat("Sensitivity") > 0 ? PlayerPrefs.GetFloat("Sensitivity")*10:100;
        Cursor.lockState = CursorLockMode.Locked; // barre le cursor et le fait disparaite
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 delta = Mouse.current.delta.ReadValue() * Time.deltaTime * sensibility;
        verticalRotation -= delta.y;
        verticalRotation = Mathf.Clamp(verticalRotation, -90, 90);
        //player.Rotate(new Vector3(0, delta.x, 0));
        transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);
        player.Rotate(Vector3.up * delta.x); // Écriture beaucoup plus lisible
    }
}
