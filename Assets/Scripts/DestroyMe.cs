using System;
using System.Collections;
using UnityEngine;

public class DestroyMe : MonoBehaviour
{
    public float delay = 3f;

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }
}
