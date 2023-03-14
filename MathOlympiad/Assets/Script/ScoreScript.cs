// code reference: https://www.youtube.com/watch?v=cOW_T3i4_kk
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoreScript : MonoBehaviour
{
    public Text Score;

    //public Text Score;
    public int ScoreNum;


    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        Score.text = "Score : " + ScoreNum;
    }

   /*@Modified: Lainya 
   * Checks for collision on coin tag which increments score when it is MyCoin
   * decrements when player collides with Hurdle tags 
   * */
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "MyCoin") 
        {
            ScoreNum += 1;
            Destroy(collision.gameObject);
            Score.text = "Score : " + ScoreNum;

        }
        if(collision.tag == "Hurdles" & ScoreNum > 0) 
        {
            ScoreNum -= 1;
            Score.text = "Score : " + ScoreNum;

        }
        if(collision.tag == "EndCheckpoint") 
        {
            PlayerPrefs.SetString("currentScore", Score.text);
            SceneManager.LoadScene("LevelComplete");
        }
    
    }

   /*@Modified: Sahil 
   * Rewards 3 points, method called when answer is correct
   * */
    public void correctAnswer()
    {
        ScoreNum += 3;
        Score.text = "Score : " + ScoreNum;
    }
    
}
