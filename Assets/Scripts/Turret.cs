using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    void Update()
    {
        SearchTarget();
    }

    void SearchTarget()
    {
        for (var i = 0; i < raycastCount; i++)
        {
            var wasHit = Raycast(i, out var hitInfo);
            
            if (wasHit)
            {
                Instantiate(explosionPrefab, hitInfo.transform.position, Quaternion.identity).SetActive(true);
                hitInfo.collider.enabled = false;
                Destroy(hitInfo.collider.gameObject);
            }
        }
    }





    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    


    private bool Raycast(int i, out RaycastHit hitInfo)
    {
        var step = sectorAngel / raycastCount;
        var angle = step * i - sectorAngel * 0.5f;
        var dir = Quaternion.Euler(0, angle, 0) * gun.forward;
        var ray = new Ray(raycastPoint.position, dir);

        if (debug)
        {
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * maxDistance, Color.blue);
        }

        return Physics.SphereCast(ray, castRadius, out hitInfo, maxDistance, layerMask, QueryTriggerInteraction.Ignore);
    }
    
    public Transform raycastPoint;
    public Transform gun;
    public float maxDistance = 20f;
    public LayerMask layerMask;
    public float sectorAngel = 90f;
    public int raycastCount = 100;
    public float castRadius = 1f;

    public GameObject explosionPrefab;
    
    public bool debug;
}
