using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableDisable : MonoBehaviour
{
    public SpriteRenderer SR;
    public enableDisable script;
    public GameObject GO;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //script.enabled = false;
            GO.SetActive(false);
            SR.enabled = false;
            
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //script.enabled = true;
            GO.SetActive(true);
            SR.enabled = true;
        }
    }
}
