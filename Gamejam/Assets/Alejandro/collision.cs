using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public Collider2D characterCollider;

    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.name == "death")
        {
            // @TODO: death things
        }
        else if (trigger.name == "clickable zone")
        {
            // @TODO: click and drag things
        }
        else if (trigger.name == "soul")
        {
            // @TODO: eating souls things
        }
        else
        {
            Debug.Log("Trigger ok");
        }
    }
}
