using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float upForce = 200f;

    private bool isDead = false; // Is The Bird Dead ?
    private Rigidbody2D rg2d;
    private Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        // Get RigidBoby2D component
        rg2d = GetComponent<Rigidbody2D>();
        // Get Animator component
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!isDead)
        {
            // If there is a left mouse click
            if(Input.GetMouseButtonDown(0))
            {
                anim.SetTrigger("Flap");
                // Reset velocity + add vertical force
                rg2d.velocity = Vector2.zero;
                rg2d.AddForce(new Vector2(0f, upForce));
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // the bird touch a collider
        isDead = true;
        rg2d.velocity = Vector2.zero;
        anim.SetTrigger("Die");
        GameController.instance.BirdDied();
    }
}
