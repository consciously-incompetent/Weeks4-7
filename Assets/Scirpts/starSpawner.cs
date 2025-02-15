using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//using static UnityEngine.RuleTile.TilingRuleOutput;

public class starSpawner : MonoBehaviour
{

    //variables being made 
    public Slider timer;
    public float starCount = 0;
    public Slider slider;
    bool timerOnOff = false;
    //qhere the prefab will go
    public GameObject star;
    // Start is called before the first frame update
    void Start()
    {
        //this was for testing
        //Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        //increses the value of the timer until it hits 8 (which is the length of the stars life)
        if (timerOnOff)
        {
            timer.value  += Time.deltaTime;
            
            if(timer.value == 8)
            {
                timerOnOff = false;
                timer.value = 0;
            }
        }




    }



    //spawns a number of the star prefabs based on star count which is increase by a slider
    //the stars are then given random positions and sizes 
     public void Spawn()
    {
        if (!timerOnOff)
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
        
    }


    //when the slider is changed that new value is given to starcount
    public void starAmount()
    {
        starCount = slider.value;
    }


}
