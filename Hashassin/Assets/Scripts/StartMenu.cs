using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject settingsMenuUI;
    public GameObject startMenuUI;
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        FindObjectOfType<AudioManager>().Play("menuClick");
    }
    public void Options()
    {
        settingsMenuUI.SetActive(true);
        startMenuUI.SetActive(false);
        FindObjectOfType<AudioManager>().Play("menuClick");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
        FindObjectOfType<AudioManager>().Play("menuClick");
    }
}
