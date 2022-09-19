using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject playerSprite;
    bool pressed = false;
    public float force = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        playerSprite = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        checkMove();

    }

    void checkMove()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && !pressed)
        {
            
            addMovement();
            pressed = true;
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            pressed = false;
            
        }
    }

    void addMovement()
    {
        
        playerSprite.GetComponent<Rigidbody2D>().AddForce(transform.up * force, ForceMode2D.Impulse);
              
    }
}
