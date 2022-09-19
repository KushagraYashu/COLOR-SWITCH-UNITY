using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderChecker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.transform.tag == "color change")
        {
            
            this.transform.parent.gameObject.GetComponent<PlayerColorManager>().ChangeColor();
            Destroy(collider.gameObject);
        }
        if(collider.tag == "hurdle")
        {
            this.transform.parent.gameObject.GetComponent<PlayerGameplayManager>().CheckColorWithHurdle(collider);
            Debug.Log("hurdle");
        }
        if(collider.tag == "end")
        {
            GameObject.FindGameObjectWithTag("end crackers").GetComponent<EndCrackers>().Diwali();
            GameObject.FindGameObjectWithTag("gameplay").GetComponent<Timer>().End();
        }
        if(collider.tag == "star")
        {
            Destroy(collider.gameObject);
            this.transform.parent.gameObject.GetComponent<PlayerGameplayManager>().Score();
            
       
        }
    }

    
}
