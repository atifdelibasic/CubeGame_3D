using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManScript : MonoBehaviour
{
    bool gameEnded = false;
    [SerializeField]
    private float restartDelay = 1f;
    public GameObject CompleteLevelUI;

   public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
    }

    public void EndGame ()
    {
        if(!gameEnded)
        {
            gameEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
