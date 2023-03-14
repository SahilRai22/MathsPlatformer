using UnityEngine;
using UnityEngine.SceneManagement;

public class LCMainMenu : MonoBehaviour
{
    /*@Modified: Lainya 
   * Loads start scene 
   * */
    public void LoadGame()
    {
        SceneManager.LoadScene("StartScene");
    }
}
