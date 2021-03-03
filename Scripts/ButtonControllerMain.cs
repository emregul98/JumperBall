using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonControllerMain : MonoBehaviour
{
    public void Letsgo()
    {
        SceneManager.LoadScene("Scenes/Bolum1");
    }
}
