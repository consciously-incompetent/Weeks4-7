using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_function : MonoBehaviour
{
    //V A R I A B L E S
    public float solution = 0;
    bool start = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //makes a variable to store the rotation points rotation
        Vector3 Rot = transform.eulerAngles;

        
        if (start)
        {
            // i use the solution float to track roation points current roation so that if it exedes -150 it can reset 
            Rot.z -= 0.1f;
            solution -= 0.1f;

            if (solution <= -150)
            {
                solution = 0;
                Rot.z = 0;
                start = false;
            }
          
            
                
            
        }


        transform.eulerAngles = Rot;
    }



    //when the buttons pressed it starts rotating 
    public void rotateMoon()
    {

        start = true;


    }
}
