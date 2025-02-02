using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float healthPool = 10;
    public Slider HealthBar;
    void Start()
    {
        HealthBar.maxValue = healthPool;
        HealthBar.minValue = 0;
        HealthBar.value = healthPool;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            takeDamage(1);
        }
    }


    public void takeDamage(float damage)
    {
        healthPool -= damage;
        HealthBar.value = healthPool;
    }
}
