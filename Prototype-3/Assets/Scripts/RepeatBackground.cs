using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;

        var bc = GetComponent<BoxCollider>();
        repeatWidth = bc.size.x / 2;
        // XXX - Is there a cost to running a collider on the background?
        // Assume there is and disable the collider after getting the width.
        bc.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
