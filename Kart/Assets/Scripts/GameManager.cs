using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool GameFinished = false;
    float RestartDelay = 1.5f;
    public GameObject displayCompleteLevel;
    public void GameOver()
    {
        if (!GameFinished)
        {
            Debug.Log("Game is over!");
            GameFinished = true;
            Restart();
            Invoke("Restart", RestartDelay);
        }
    }

    public void CompleteLevel()
    {
        if (!GameFinished)
        {
            Debug.Log("Level complete!");
            displayCompleteLevel.SetActive(true);
        }
    }


    public void Restart()
    {
        // Since we're restarting, reset the flag to be false
        GameFinished = false;

        // This restarts the scene, but there are a few lighting problems (handled within Unity)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
