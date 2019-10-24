using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerActions : MonoBehaviour
{
    #region variables
    public Collider2D characterCollider;
    public GameObject canvasRetry;
    public DragNDrop dragNDrop;

    private int soulsEaten;
    #endregion

    private void Start() {
        // Starts the player.
        this.enabled = true;

        // Sets enabled the click & Drag script.
        
        // Restarts the count souls.
        soulsEaten = 0;
    }

    public void resetCharacter()
    {
        // Starts the player.
        this.enabled = true;

        // Restarts the count souls.
        soulsEaten = 0;
    }

    private void spawnRetryCanvas()
    {
        canvasRetry.SetActive(true);
    }

    //private int getSoulEated(Collider2D trigger) {
    //    int retVal = 0;

    //    retVal = int.Parse(trigger.name.Split("("[0])[1].Split(")"[0])[0]);

    //    return retVal;
    //}

    public void addOneSoul() {
        soulsEaten++;
    }

    public void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.name == "TriggerDeath")
        {
            //Destroy(this.gameObject);
            this.gameObject.SetActive(false);

            Time.timeScale = 0;

            spawnRetryCanvas();
        }
        //else if (trigger.name == "TriggerClickableZone")
        //{
        //    // @TODO: click and drag things
        //    Debug.Log("CLICK AND DRAG ACTIVE");
        //    dragNDrop.enabled = true;
        //}
    }

    //public void OnTriggerExit2D(Collider2D trigger)
    //{
    //    if (trigger.name == "TriggerClickableZone")
    //    {
    //        // @TODO: click and drag things
    //        Debug.Log("CLICK AND DRAG NO active");
    //        dragNDrop.enabled = false;
    //    }
    //}
}
