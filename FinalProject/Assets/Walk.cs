using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 temp = rb.velocity;

        // running:
        temp.x = Input.GetAxis("Horizontal") * speed;
        temp.y = Input.GetAxis("Vertical") * speed;
        rb.velocity = temp;

    }
    }
