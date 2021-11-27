using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;

    public float spawnEvery = 1f;

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), 0, spawnEvery);
    }

    private void Spawn()
    {
        var go = Instantiate(prefab, transform.position + Random.insideUnitSphere * transform.lossyScale.x, Quaternion.identity);
    }
}
