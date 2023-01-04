using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
   public void restartGame()
    {
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
        SetScore.isLost = false;
        SetScore.score = 0;
    }
    
}
