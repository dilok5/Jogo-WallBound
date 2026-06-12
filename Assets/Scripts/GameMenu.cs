using UnityEngine;
using UnityEngine.SceneManagement;


public class GameMenu : MonoBehaviour
{
    public GameObject HomeMenuPanel, CreditScreenPanel;
    public string nameOfFirstScene;

    public void LoadGame()
    {
        SceneManager.LoadScene(nameOfFirstScene);
    }

    public void ActivateHomeMenuPanel()
    {
        CreditScreenPanel.SetActive(false);
        HomeMenuPanel.SetActive(true);
    }

    public void ActivateCreditsScreenPanel()
    {
        HomeMenuPanel.SetActive(false);
        CreditScreenPanel.SetActive(true);
    }

    public void QuitGame()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }
}
