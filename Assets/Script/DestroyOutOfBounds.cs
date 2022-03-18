using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float xLim = -4f;
    void Update()
    {
        if (transform.position.x < xLim)
        {
            Destroy(gameObject);
        }
    }
}
