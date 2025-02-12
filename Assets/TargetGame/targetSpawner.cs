using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetSpawner : MonoBehaviour
{
    public GameObject targetPrefab;
    public int NMBtargets = 5;
    public List<GameObject> targets;
    public SpriteRenderer win;

    private void Start()
    {
        targets = new List<GameObject>();
        for (int i = 0; i < NMBtargets; i++)
        {
            GameObject newTarget =  Instantiate(targetPrefab);
            newTarget.transform.position = Random.insideUnitCircle * 5;

            TargetScript t = newTarget.GetComponent<TargetScript>();
            t.spawner = this;

            targets.Add(newTarget);
        }
    }

    public void TargetHit(GameObject t)
    {
        targets.Remove(t);

        
    }

}
