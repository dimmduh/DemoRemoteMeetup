using System;
using System.Collections;
using UnityEngine;

public class Pool : MonoBehaviour
{
    public int startCount = 50000;
    public GameObject prefab;
    
    private void Start()
    {
        for (var i = 0; i < startCount; i++)
        {
            Instantiate(prefab, transform);
        }
    }
}
