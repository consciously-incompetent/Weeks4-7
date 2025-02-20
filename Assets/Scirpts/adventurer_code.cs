using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class adventurer_code : MonoBehaviour
{

    public AnimationCurve curve;
    float t;
    Vector2 currentPos;
    Vector2 current_mousePos;
    public Transform ghost;
    // Start is called before the first frame update
    void Start()
    {
        currentPos = transform.position;
        current_mousePos.x = 0;
        current_mousePos.y = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        t += Time.deltaTime;
        
        //Vector2 Pos = transform.position;
        //Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        if (Input.GetMouseButtonDown(0))
        {
            currentPos = transform.position;
            current_mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            t = 0;
        }



        if (Vector2.Distance(ghost.position, transform.position) <= 1 && ghost.GetComponent<Dangerous>() != null)
        {

            Destroy(gameObject);

        }
        


        transform.position = Vector2.Lerp(currentPos, current_mousePos, curve.Evaluate(t));




    }



    
}
