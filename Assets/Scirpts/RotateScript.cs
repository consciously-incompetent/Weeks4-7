using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    public float rotationTracker;
    public AudioSource chime;
    public GameObject bird;
    float chimeTracker;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Pos = transform.eulerAngles;
        Pos.z += 1;
        rotationTracker += 1;


        if(rotationTracker%270 == 0)
        {
            chimeTracker += 1;
            chime.Play();


        }

        if (chime.isPlaying)
        {
            bird.SetActive(true);
        }
        else
        {
            bird.SetActive(false);
        }

        transform.eulerAngles = Pos;
             
        
    }
}
