using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class DisableOverTimeComponent : MonoBehaviour
{
    public float timeBeforeDisable = 5;
    public Action onDisable;
    float elapsedTime;

    private void OnEnable()
    {
        elapsedTime = 0;
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > timeBeforeDisable)
        {
            var objectToDisable = gameObject;
            onDisable.Invoke();
            objectToDisable.SetActive(false);
            elapsedTime = 0;
        }
    }
}
