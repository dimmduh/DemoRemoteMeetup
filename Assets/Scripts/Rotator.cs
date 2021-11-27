using System;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Vector3 speed;

    private void Update()
    {
        transform.Rotate(speed * Time.smoothDeltaTime);
    }
}
