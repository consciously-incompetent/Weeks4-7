using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MovingGuy : MonoBehaviour
{
    public Image reaction;
    public Sprite[] sprite_list;
    public GameObject speechBubble;
    public Transform Npc;
    bool Lock = false;
   
    // Start is called before the first frame update
    void Start()
    {
        speechBubble.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 guyPos = transform.position;
        

        guyPos.x += Input.GetAxis("Horizontal") * 7 * Time.deltaTime;
        guyPos.y += Input.GetAxis("Vertical") * 7 * Time.deltaTime;


        

        



        if (Vector2.Distance(guyPos, Npc.position) <= 2)
        {
            if (!Lock)
                {
                    reaction.sprite = sprite_list[Random.Range(0, 3)];
                    Lock = true;
                }
            //reaction.sprite = sprite_list[Random.Range(0, 3)];
            speechBubble.SetActive(true);
            
        }
        else
        {
            speechBubble.SetActive(false);
            Lock = false;
            
        }






        transform.position = guyPos;


    }
}
