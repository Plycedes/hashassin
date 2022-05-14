using UnityEngine;


public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject gameUI;

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
    }
    public void MainMenu()
    {

    }
}
