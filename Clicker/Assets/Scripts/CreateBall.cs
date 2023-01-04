using UnityEngine;
using System.Collections;

public class CreateBall : MonoBehaviour
{
    private float waitTime;
    public GameObject redBall, greenBall;
    private bool isSpawn;
    private Coroutine spawnR, spawnG;

    private void Update()
    {
        if(StartGame.isStart && !isSpawn)
        {
            spawnR = StartCoroutine(spawnRedBalls());
            spawnG = StartCoroutine(spawnGreenBalls());

            isSpawn = true;
        }
    }
    IEnumerator spawnRedBalls()
    {
        while(true)
        {
            waitTime = Random.Range(2f, 3f);
            yield return new WaitForSeconds(waitTime);
            if (StartGame.isStart)
            {
                GameObject RB = Instantiate(redBall, new Vector2(Random.Range(-1.8f, 1.8f), Random.Range(-4.4f, 4.4f)), Quaternion.identity);
               Destroy(RB, 2f);
            }
            else
            {
                StopCoroutine(spawnR);
            }
        }

    }
    IEnumerator spawnGreenBalls()
    {
        while(true)
        {
            waitTime = Random.Range(0.5f, 1.5f);
            yield return new WaitForSeconds(waitTime);
            if (StartGame.isStart)
            {
               GameObject GB = Instantiate(greenBall, new Vector2(Random.Range(-1.8f, 1.8f), Random.Range(-4.4f, 4.4f)), Quaternion.identity);
                Destroy(GB, 2f);
            }
            else
            {
                StopCoroutine(spawnG);
            }
        }

    }
}
