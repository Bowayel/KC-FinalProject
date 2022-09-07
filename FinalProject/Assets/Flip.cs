using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    SpriteRenderer sprite;
    bool faceRight = true;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Flipplayer();
    }
    
    void Flipplayer()
    {
        if (Input.GetKeyDown(KeyCode.D) && faceRight == true)
        {
            sprite.flipX = true;
            faceRight = false;
        }
        else if (Input.GetKeyDown(KeyCode.A) && faceRight == false)
        {
            sprite.flipX = false;
            faceRight = true;
        }
    }

}
