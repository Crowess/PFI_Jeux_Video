using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class DisableOverTimeComponent : MonoBehaviour
{
    [SerializeField] float baseTime = 10f;
    GameObject player;
    public float timeBeforeDisable;
    public Action onDisable;
    float elapsedTime;

    private void Awake()
    {
        timeBeforeDisable = PlayerPrefs.GetFloat("Difficulty") > 1 ? baseTime/PlayerPrefs.GetFloat("Difficulty") : baseTime;
        player = GameObject.Find("Player");
    }


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
            player.GetComponent<FireComponent>().ResetStreak("Too slow! Streak lost....");
        }
    }
}
