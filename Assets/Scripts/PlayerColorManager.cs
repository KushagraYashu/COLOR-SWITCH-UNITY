using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorManager : MonoBehaviour
{
    public SpriteRenderer playerSprite; 
    
    // Start is called before the first frame update
    void Start()
    {
        playerSprite.color = new Color(255, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeColor()
    {
        var a = Random.Range(0, GameObject.FindGameObjectWithTag("color manager").GetComponent<ColorManager>().colors.Length);
        var colorName = GameObject.FindGameObjectWithTag("color manager").GetComponent<ColorManager>().colors[a];
        //Debug.Log(GameObject.FindGameObjectWithTag("color manager").GetComponent<ColorManager>().colors);
        switch(colorName){
            case "Red":
                playerSprite.color = new Color(255, 0, 0);
                break;
            case "Blue":
                playerSprite.color = new Color(0, 0, 255);
                break;
            case "White":
                playerSprite.color = new Color(255, 255, 255);
                break;
            case "Yellow":
                playerSprite.color = new Color(255, 255, 0);
                break;
        }
        
    }
}
