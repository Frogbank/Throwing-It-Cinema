using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Menu : MonoBehaviour
{
    public Button settingsButton;
    public Button exitButton;
    public Button playButton;
    public Button backButton;
    public Button playBackButton;

    public Canvas throwItBack;

    public Canvas canvas;

    public Canvas mainMenu;
    public Canvas settingsMenu;
    public Canvas playMenu;

    public Slider cheeseSlider;
    private float cheeseLevel;


    public VideoPlayer cinema;

    public VideoClip[] clips;




    private void Start()
    {
        settingsButton.onClick.AddListener(SettingsButton);
        exitButton.onClick.AddListener(ExitButton);
        playButton.onClick.AddListener(PlayButton);
        backButton.onClick.AddListener(ThrowItBackButton);
        playBackButton.onClick.AddListener(ThrowItBackButton);

        

    }

    private void SettingsButton()
    {
        mainMenu.gameObject.SetActive(false);
        settingsMenu.gameObject.SetActive(true);
        playMenu.gameObject.SetActive(false);


    }

    private void ExitButton()
    {
        Application.Quit();

    }
    private void PlayButton()
    {
        mainMenu.gameObject.SetActive(false);
        settingsMenu.gameObject.SetActive(false);
        playMenu.gameObject.SetActive(true);


        if(UnityEngine.Random.Range(cheeseLevel, 1.0f) > 0.5f)
        {
            cinema.clip = clips[0];
        }
        else
        {
            cinema.clip = clips[1];
        }


    }

    private void ThrowItBackButton()
    {
        mainMenu.gameObject.SetActive(true);
        settingsMenu.gameObject.SetActive(false);
        playMenu.gameObject.SetActive(false);


        StartCoroutine(ThrowItBack());
    }



    private IEnumerator ThrowItBack()
    {

        throwItBack.gameObject.SetActive(true);

        yield return new WaitForSeconds(1.0f);

        throwItBack.gameObject.SetActive(false);


    }


    public void Slider()
    {
        cheeseLevel = cheeseSlider.value;
    }


}
