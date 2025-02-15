using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_function : MonoBehaviour
{

    public float solution = 0;
    bool start = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Rot = transform.eulerAngles;


        if (start)
        {
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




    public void rotateMoon()
    {

        start = true;


    }
}
