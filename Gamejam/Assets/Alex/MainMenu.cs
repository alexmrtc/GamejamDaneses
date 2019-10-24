using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject creditsMenu;

    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Theme");
    }

    // Update is called once per frame
    void Update()
    {
        //Cursor.visible = true --> Para hacer que el cursor sea visible
        
    }

    public void Play()
    {
        SceneManager.LoadScene("Play");
        FindObjectOfType<AudioManager>().Play("ButtonClick");
    }

    public void ButtonClick()
    {
        FindObjectOfType<AudioManager>().Play("ButtonClick");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void ShowCreditsHideMenu()
    {
        mainMenu.SetActive(false);
        creditsMenu.SetActive(true);
    }

    public void ShowMenuHideCredits()
    {
        creditsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
