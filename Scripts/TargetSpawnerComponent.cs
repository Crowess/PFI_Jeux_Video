using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawnerComponent : MonoBehaviour
{
    [SerializeField] ObjectPoolComponent targetPool;
    [SerializeField] GameObject joueur;
    [SerializeField] float timer;
    [SerializeField] float radius = 1;
    void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    void Spawn()
    {
        GameObject objectSpawned = targetPool.GetObject();
        objectSpawned.transform.position = (new Vector2(2, 2) + Random.insideUnitCircle * radius);
        objectSpawned.transform.LookAt(joueur.transform);
        objectSpawned.SetActive(true);
    }
}
