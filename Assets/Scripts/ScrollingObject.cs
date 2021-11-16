using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    private Rigidbody2D rg2d;
    // Start is called before the first frame update
    void Start()
    {
        rg2d = GetComponent<Rigidbody2D>();
        rg2d.velocity = new Vector2(GameController.instance.scrollSpeed, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameController.instance.gameOver)
        {
            rg2d.velocity = Vector2.zero;
        }
    }
}
