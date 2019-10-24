using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    #region variables
    public Collider2D characterCollider;
    public GameObject[] souls;
    public GameObject canvasRetry;
    public Transform spawnPoint;

    private int soulsEaten;
    #endregion

    private void Start() {
        // Starts the player
        this.enabled = true;
        
        // Restarts the count souls.
        soulsEaten = 0;

        // Actives again all the souls so they can be eaten again.
        for (int i = 0; i < souls.Length; i++)
        {
            souls[i].SetActive(true);
        }
    }

    public void resetCharacter()
    {
        // Sets the position
        this.transform.position = spawnPoint.position;

        // Starts the player
        this.enabled = true;

        // Restarts the count souls.
        soulsEaten = 0;

        // Actives again all the souls so they can be eaten again.
        for (int i = 0; i < souls.Length; i++)
        {
            souls[i].SetActive(true);
        }
    }

    private void spawnRetryCanvas()
    {

        canvasRetry.SetActive(true);
    }

    private int getSoulEated(Collider2D trigger) {
        int retVal = 0;

        retVal = int.Parse(trigger.name.Split("("[0])[1].Split(")"[0])[0]);

        return retVal;
    }

    public void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.name == "TriggerDeath")
        {
            //Destroy(this.gameObject);
            this.enabled = false;
            spawnRetryCanvas();
        }
        else if (trigger.name == "TriggerClickableZone")
        {
            // @TODO: click and drag things
        }
        else
        {
            soulsEaten++;

            int n_soulEaten = getSoulEated(trigger);

            //Debug.Log(n_soulEaten);

            // There's a -1 so we can start counting in the viewport from 1 and not 0 (easier for artists I think).
            // Uncomment the line after when the souls have been placed in map and inspector.
            
            //souls[n_soulEaten - 1].SetActive(false);
        }
    }
}
