using UnityEngine;

public class HideInHierarchy : MonoBehaviour
{
    void Awake()
    {
        gameObject.hideFlags = HideFlags.HideInHierarchy;
    }
}