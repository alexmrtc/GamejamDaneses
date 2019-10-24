using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RetryCanvasControl : MonoBehaviour
{
    public GameObject canvasRetry;
    //public Transform spawnPosition;
    //private Quaternion spawnQuaternion;
    public collision character;
    

    public void yesButton()
    {
        canvasRetry.SetActive(false);

        //Instantiate(character, spawnPosition.position, spawnQuaternion);
        //Instantiate(character, spawnPosition);

        character.resetCharacter();
    }

    public void noButton()
    {
        canvasRetry.SetActive(false);
        
        // Load main scene (title scene)

    }
}
