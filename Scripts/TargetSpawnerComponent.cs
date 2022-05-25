using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawnerComponent : MonoBehaviour
{
    [SerializeField] ObjectPoolComponent targetPool;
    [SerializeField] GameObject joueur;
    [SerializeField] float cooldown = 5;
    [SerializeField] float radius = 40;
    float elapsedTime = 0f;

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
        Vector3 positionTarget = new Vector3(2,2,2)+Random.insideUnitSphere * radius;
        positionTarget.y = joueur.transform.position.y;
        objectSpawned.transform.position = positionTarget;
        objectSpawned.transform.LookAt(joueur.transform);
        objectSpawned.SetActive(true);
    }
}
