using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawnerComponent : MonoBehaviour
{
    [SerializeField] ObjectPoolComponent targetPool;
    [SerializeField] GameObject joueur;
    [SerializeField] float cooldown;
    [SerializeField] float radius = 30;
    float elapsedTime = 0f;
    const float baseCooldown = 5f;


    private void Awake()
    {
        float difficulty = PlayerPrefs.GetFloat("Difficulty");
        cooldown = difficulty > 0 ? baseCooldown / difficulty : baseCooldown;
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= cooldown)
        {
            elapsedTime -= cooldown;
            Spawn();
        }
    }

    void Spawn()
    {
        GameObject objectSpawned = targetPool.GetObject();
        Vector3 positionTarget = new Vector3(10,10,10)+Random.insideUnitSphere * radius;
        positionTarget.y = joueur.transform.position.y;
        objectSpawned.transform.position = positionTarget;
        objectSpawned.transform.LookAt(joueur.transform);
        objectSpawned.SetActive(true);
    }
}
