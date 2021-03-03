using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Admin : MonoBehaviour
{
    int score;
    float passCube;
    public float totalCube;

    public TMPro.TextMeshProUGUI point;
    public Slider slider;

    public GameObject panel;
    public GameObject panelfail;
    public Button settingspanel;

    public void passcube()
    {
        score += 25;
        point.text = score.ToString();

        passCube += +1.0f;
        slider.value = passCube / totalCube;
    }
    public void startagain()
    {
        panelfail.SetActive(true);
        Time.timeScale = 0f;
        settingspanel.interactable = false;
    }

    public void nextstage()
    {
        panel.SetActive(true);
        Time.timeScale = 0.3f;
        settingspanel.interactable = false;

    }
    public void FailClick()
    {
        SceneManager.LoadScene("Scenes/Bolum1");
        Time.timeScale = 1f;
    }
    public void Click()
    {
        SceneManager.LoadScene("Scenes/Bolum1");
        Time.timeScale = 1f;
    }
}

