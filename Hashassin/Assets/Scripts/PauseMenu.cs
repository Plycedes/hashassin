using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject gameUI;

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        gameUI.SetActive(false);
        Time.timeScale = 0;
        FindObjectOfType<AudioManager>().Play("menuClick");
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        gameUI.SetActive(true);
        Time.timeScale = 1;
        FindObjectOfType<AudioManager>().Play("menuClick");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        FindObjectOfType<AudioManager>().Play("menuClick");
    }
    public void Quit()
    {
        Application.Quit();
        FindObjectOfType<AudioManager>().Play("menuClick");
    }
}
