using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public float retreaDistance;
    
    public Transform player;
    



    // Start is called before the first frame update

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }



    // Update is called once per frame

    void Update()

    {
        if (Vector2.Distance(transform.position, player.position) > stoppingDistance)

        {

            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

        }
        else if (Vector2.Distance(transform.position, player.position) > stoppingDistance && Vector2.Distance(transform.position, player.position) > retreaDistance)

        {

            transform.position = this.transform.position;

        }

        else if (Vector2.Distance(transform.position, player.position) > retreaDistance)

        {

            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);

        }
     

    }

}
