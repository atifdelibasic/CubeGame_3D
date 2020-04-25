using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        // na osnovu building decks-a
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
