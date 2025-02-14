using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{

    
    
    public float size = 0f;
    public float locationX = 0;
    public float locationY = 0;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 starSize = transform.localScale;
        Vector2 starPos = transform.position;
        starPos.x = locationX;
        starPos.y = locationY;
        starSize = Vector3.one * size;
        transform.position = starPos;
        transform.localScale = starSize;
        

       



        //im not using the below code because it seams to similar to what was taught during homework and i dont know if that would count as plagarizism or not
        //just being careful
        //gameObject.transform.position = Random.insideUnitCircle * 5;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
