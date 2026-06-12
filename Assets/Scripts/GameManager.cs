using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string HomeMenuName;
    public static int score;
    private TextMeshProUGUI NumberScore;
    public string nameOfNextScene;
    public float timeForReloadPhase;
    public float timeForReloadNewPhase;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Destroi GameManager antigo se existir
        GameManager[] managers = FindObjectsByType<GameManager>(FindObjectsSortMode.None);
        foreach (GameManager gm in managers)
        {
            if (gm != this)
            {
                Destroy(gm.gameObject);
            }
        }

        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject textObject = GameObject.Find("Number Score");
        if (textObject != null)
        {
            NumberScore = textObject.GetComponent<TextMeshProUGUI>();
            NumberScore.text = score.ToString();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            BackToMenu();
        }
    }

    private void BackToMenu()
    {
        SceneManager.LoadScene(HomeMenuName);
    }

    public void GameOver()
    {
        RunCoroutineReloadPhase();
    }

    public void RunCoroutineReloadPhase()
    {
        StartCoroutine(ReloadPhase());
    }

    private IEnumerator ReloadPhase()
    {
        yield return new WaitForSeconds(timeForReloadPhase);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void RunCoroutinePassTheStage()
    {
        StartCoroutine(PassTheStage());
    }

    private IEnumerator PassTheStage()
    {
        yield return new WaitForSeconds(timeForReloadNewPhase);
        SceneManager.LoadScene(nameOfNextScene);
    }
}
