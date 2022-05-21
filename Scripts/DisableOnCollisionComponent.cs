using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

[RequireComponent(typeof(AudioSource))]
public class DisableOnCollisionComponent : MonoBehaviour
{
    private void Awake()
    {
    }
    private void OnCollisionEnter(Collision collision)
    {
        var objectDisable = gameObject;
        objectDisable.SetActive(false);
    }


}
