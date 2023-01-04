using UnityEngine;

public class RedBall : MonoBehaviour
{
   
        
    void OnMouseDown()
    {
        if (SetScore.isLost == false)
        {
            StartGame.isStart = false;
            SetScore.isLost = true;
        }
    }

}
