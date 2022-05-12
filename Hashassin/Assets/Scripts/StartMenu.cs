using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject settingsMenuUI;
    public GameObject startMenuUI;
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Options()
    {
        settingsMenuUI.SetActive(true);
        startMenuUI.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
