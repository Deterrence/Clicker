using UnityEngine;
using UnityEngine.UI;

public class SetScore : MonoBehaviour
{
   public static short score = 0;
   public static bool isLost = false;
   public Text scoreText;
   public GameObject losePanel;
    private void Update()
    {
        scoreText.text = "Score: " + score.ToString();
        if (PlayerPrefs.GetInt("score") < score)
            PlayerPrefs.SetInt("score", score);

        if (isLost)
        {
            losePanel.SetActive(true);
        }
    }
   
}
