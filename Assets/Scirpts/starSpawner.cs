using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static UnityEngine.RuleTile.TilingRuleOutput;

public class starSpawner : MonoBehaviour
{


    
    public int starCount = 0;
    public GameObject star;
    // Start is called before the first frame update
    void Start()
    {
        //Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }




     public void Spawn()
    {
        
        for (int i = 0; i < starCount; i++)
        {
            GameObject newStar = Instantiate(star);
            newStar.GetComponent<Star>().size = Random.Range(0.1f, 1f);
            newStar.GetComponent<Star>().locationX = Random.Range(-9, 9);
            newStar.GetComponent<Star>().locationY = Random.Range(-4.5f, 4.5f);

        }
        
    }
}
