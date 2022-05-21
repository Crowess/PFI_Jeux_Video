using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(DisableOverTimeComponent))]
public class TargetComponent : MonoBehaviour,IPoolable
{
    public ObjectPoolComponent AssociatedPool { get; set; }

    void Awake()
    {
        GetComponent<DisableOverTimeComponent>().onDisable = () =>
        {
            AssociatedPool.PutObject(gameObject);
        };
    }

    // Update is called once per frame
    void Update()
    {
    }
}
