using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public float speed = 1;
    public AnimationCurve curve;
    public Color col;
    public SpriteRenderer SR;
    float t;
    bool IsDead = false;
    public targetSpawner spawner;
    void Start()
    {
        speed = Random.Range(1, 5);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        pos.x += speed * Time.deltaTime;

        if(screenPos.x < 0)
        {
            speed = speed * -1;
            pos.x = Camera.main.ScreenToWorldPoint(new Vector2(0,0)).x;
        }

        if(screenPos.x > Screen.width)
        {
            speed = speed * -1;
            pos.x = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x; 
        }

        transform.position = pos;


        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(SR.bounds.Contains(mousePos))
            {
                //Destroy;
                SR.color = col;
                IsDead = true;
                Destroy(gameObject, 1);
                spawner.TargetHit(gameObject);

            }
        }

        if (IsDead)
        {
            t += Time.deltaTime;
            transform.localScale = Vector3.one * curve.Evaluate(t); 
        }

    }
}
