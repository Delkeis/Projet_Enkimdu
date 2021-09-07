using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public GameObject myDeathMenu;
    public Button RestartButton;
    public Button MenuButton;
    private GameObject myPlayer;
    void Start()
    {
        myPlayer = GameObject.Find("Player");
        myDeathMenu = GameObject.FindGameObjectWithTag("DeathMenuTag");
        //RestartButton = gameObject.GetComponent<Button>();
        RestartButton.onClick.AddListener(RestartOnclick);
        MenuButton.onClick.AddListener(loadMainMenu);
        myDeathMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(myPlayer.GetComponent<Health>().getLife());
        if (myPlayer.GetComponent<Health>().getLife() <= 0){
            myPlayer.GetComponent<PlayerController>().setMouseControl(false);
            myDeathMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void    loadMainMenu(){
        SceneManager.LoadScene("MainMenu");
    }

    void RestartOnclick(){
        myDeathMenu.SetActive(false);
        Time.timeScale = 1;
        RestartScene();
    }
    public void RestartScene(){
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
