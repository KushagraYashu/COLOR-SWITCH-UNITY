using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerGameplayManager : MonoBehaviour
{
    public GameObject particleSys;
    public int score = 0;
    public Text scoreTXT;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckColorWithHurdle(Collider2D col)
    {
        var a = col.gameObject.GetComponent<SpriteRenderer>().color;
        var b = this.gameObject.GetComponentInChildren<SpriteRenderer>().color;
        Debug.Log(b);
        Debug.Log(a);
        if (a == b)
        {
            Debug.Log("Passed");
        }
        else
        {
            Debug.Log("NOt PAssed");
            particleSys.transform.position = this.gameObject.GetComponentInChildren<SpriteRenderer>().gameObject.transform.position;
            particleSys.SetActive(true);
            particleSys.GetComponent<ParticleSystem>().Play();
            GameObject.FindGameObjectWithTag("gameplay").GetComponent<Timer>().Dead();
            Destroy(this.gameObject);
            
        }
    }

    public void Score()
    {
        score++;
        scoreTXT.text = "" + score;
    }
}
