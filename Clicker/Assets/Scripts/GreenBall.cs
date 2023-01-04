using UnityEngine;
using UnityEngine.UI;

public class GreenBall : MonoBehaviour
{
    
    private void OnMouseDown()
    {
       if(SetScore.isLost == false) {
            SetScore.score++;
            Destroy(gameObject); }
        
    }
}
