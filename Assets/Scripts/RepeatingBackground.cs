﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    private BoxCollider2D groundCollider;
    private float groundSize;

    // Start is called before the first frame update
    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D>();
        groundSize = groundCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -groundSize)
        {
            RepositionBackground();
        }
    }

    private void RepositionBackground()
    {
        Vector2 offset = new Vector2(groundSize * 2, 0f);
        transform.position = (Vector2)transform.position + offset;

    }
}
