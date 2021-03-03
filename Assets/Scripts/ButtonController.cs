using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public GameObject settingspanel;
    public GameObject panel;
    public void Settings()
    {
        settingspanel.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void Continue()
    {
        settingspanel.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Scenes/MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
