using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject myMainMenu;
    private GameObject mySettingsMenu;
    public Button settingBackButton;
    public Button mainSettingsButton;
    public Button  startButton;

    void Start()
    {
        myMainMenu = GameObject.FindGameObjectWithTag("MainMenuTag");
        mySettingsMenu = GameObject.FindGameObjectWithTag("SettingsMenuTag");
        mySettingsMenu.SetActive(false);
        settingBackButton.onClick.AddListener(loadMainMenu);
        mainSettingsButton.onClick.AddListener(loadSettingsMenu);
        startButton.onClick.AddListener(loadGameLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void    loadGameLevel(){
        SceneManager.LoadScene("LvlScene");
    }
    void    loadSettingsMenu(){
        myMainMenu.SetActive(false);
        mySettingsMenu.SetActive(true);
    }
    void    loadMainMenu(){
        myMainMenu.SetActive(true);
        mySettingsMenu.SetActive(false);
    }
}
