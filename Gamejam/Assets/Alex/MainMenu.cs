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
    public GameObject settingsMenu;

    public Button playButton;
    public Button settingsButton;
    public Button quitButton;

    public Sprite play;
    public Sprite setting;
    public Sprite quit;

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
        SceneManager.LoadScene("Colliders");
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

    public void ShowSettingsHideMenu()
    {
        playButton.image.sprite = setting;

        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void ShowMenuHideSettings()
    {
        settingsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void OnHighLightPlayBtn()
    {
        playButton.image.sprite = play;
    }

    public void OnHighLightSettingBtn()
    {
        playButton.image.sprite = setting;
    }
    public void OnHighLightQuitBtn()
    {
        playButton.image.sprite = quit;
    }
}
