using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{




    public float charSpeed = 5;
    bool isJumping = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 charPos = transform.position;


        charPos.x += Input.GetAxis("Horizontal") * charSpeed * Time.deltaTime;




        if (Input.GetKeyDown(KeyCode.Space))
        {

            isJumping = true;

            
        }


        if (isJumping)
        {
            charPos.y += 1;
            if (charPos.y >= 5)
            {
               isJumping = false;
            }
        }






        transform.position = charPos;






    }
}
