using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerComponent : MonoBehaviour
{
    [SerializeField] ObjectPoolComponent pool;
    [SerializeField]float cooldown = 5f;
    float elapsedTime = 0f;
    
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if(elapsedTime >= cooldown)
        {
            elapsedTime -= cooldown; 
            Spawn();
        }
    }

    private void Spawn()
    {
        GameObject spawnedObject = pool.GetObject();
        spawnedObject.transform.position = new Vector3(Random.Range(-8,8),transform.position.y, transform.position.z);
        spawnedObject.transform.rotation = transform.rotation;
        spawnedObject.SetActive(true);
    }
}
