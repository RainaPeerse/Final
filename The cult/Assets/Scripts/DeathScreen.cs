using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitButton()
    {
        SceneManager.LoadScene("Application.Quit");
    }
}
