using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public float hideSpeed = 5f;
    public GameObject logoText, scoreText, playButton;
    public static bool isStart;

    private void Update()
    {
        if (isStart && logoText != null)
            logoText.transform.Translate(Vector2.up * hideSpeed * Time.deltaTime);

    }

    public void startGame()
    {
        if (isStart)
            return;
        isStart = true;
        Destroy(logoText, 3f);

        GetComponent<Animation>().Play("HidePlayButton");
        scoreText.SetActive(true);
        playButton.GetComponent<Button>().enabled = false;
    }

}
