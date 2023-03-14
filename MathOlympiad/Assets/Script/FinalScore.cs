using UnityEngine;
using UnityEngine.UI;


public class FinalScore : MonoBehaviour
{
    public Text currentScore;
    public ScoreScript scoreScript;


    /*@Modified: Lainya 
    * Updates final score
    * */
    void Start()
    {
        currentScore.text = "Your Score: " + scoreScript.ScoreNum;
    }
    
}
