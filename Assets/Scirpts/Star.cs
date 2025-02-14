using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Star : MonoBehaviour
{


    public SpriteRenderer starSR;
    public float size = 0f;
    public float locationX = 0;
    public float locationY = 0;
    float t = 0;
    float limit = 0;

    // Start is called before the first frame update
    void Start()
    {
        starSR = GetComponent<SpriteRenderer>();
        Vector2 starSize = transform.localScale;
        Vector2 starPos = transform.position;
        starPos.x = locationX;
        starPos.y = locationY;
        starSize = Vector3.one * size;
        transform.position = starPos;
        transform.localScale = starSize;
        limit = Random.Range(1, 8);






        //im not using the below code because it seams to similar to what was taught during homework and i dont know if that would count as plagarizism or not
        //just being careful
        //gameObject.transform.position = Random.insideUnitCircle * 5;

    }

    // Update is called once per frame
    void Update()
    {
        t += 1 *Time.deltaTime;
        starSR.color = new Color(1, 1, 0,1- t*0.3f);
        //above code was provided by https://stuartspixelgames.com/2019/02/19/how-to-change-sprites-colour-or-transparency-unity-c/ 
        // it has been changed slighltly but this is how i got a hold of the transparency of my sprite
        if (t > limit)
        {
            Destroy(gameObject);
        }

    }
}
