using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackGround : MonoBehaviour
{
    private Vector3 startPosition;
    public float repeatWith;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        repeatWith = GetComponent<BoxCollider>().size.x / 2f;

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < startPosition.x - repeatWith)
        {
            transform.position = startPosition;
        }
    }
}
