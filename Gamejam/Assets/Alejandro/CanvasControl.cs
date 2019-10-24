using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasControl : MonoBehaviour
{
    public GameObject canvasRetry;
    public GameObject canvasPause;
    public TriggerActions character;

    public void resumeButton()
    {
        canvasPause.SetActive(false);

        // Returns the game to its normal runtime
        Time.timeScale = 1;
    }

    public void quitButton()
    {
        canvasPause.SetActive(false);

        // Load main scene (title scene)
        SceneManager.LoadScene("MainMenu");

        // Returns the game to its normal runtime
        Time.timeScale = 1;
    }

    public void yesButton()
    {
        canvasRetry.SetActive(false);

        // Loads the same scene
        SceneManager.LoadScene("Colliders");

        // Returns the game to its normal runtime
        Time.timeScale = 1;
    }

    public void noButton()
    {
        canvasRetry.SetActive(false);

        // Load main scene (title scene)
        SceneManager.LoadScene("MainMenu");

        // Returns the game to its normal runtime
        Time.timeScale = 1;

    }
}
