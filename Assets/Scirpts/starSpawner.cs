using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//using static UnityEngine.RuleTile.TilingRuleOutput;

public class starSpawner : MonoBehaviour
{


    
    public float starCount = 0;
    public Slider slider;
    float t;
    bool timerOnOff = false;

    public GameObject star;
    // Start is called before the first frame update
    void Start()
    {
        //Spawn();
    }

    // Update is called once per frame
    void Update()
    {

        if (timerOnOff)
        {
            t += Time.deltaTime;
        }




    }




     public void Spawn()
    {
        timerOnOff = true;
        for (int i = 0; i < starCount; i++)
        {
            GameObject newStar = Instantiate(star);
            newStar.GetComponent<Star>().size = Random.Range(0.1f, 0.5f);
            newStar.GetComponent<Star>().locationX = Random.Range(-9, 9);
            newStar.GetComponent<Star>().locationY = Random.Range(-4.5f, 4.5f);
            
        }
        
    }



    public void starAmount()
    {
        starCount = slider.value;
    }


}
