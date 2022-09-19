using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
{
    public int color_R;
    public int color_G;
    public int color_B;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color(color_R, color_G, color_B);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
