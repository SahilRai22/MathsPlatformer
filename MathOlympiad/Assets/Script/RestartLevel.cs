using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
   /*@Modified: Lainya 
   * Restart to level 1
   * */
    public void LoadGame()
    {
        SceneManager.LoadScene("Level-1");
    }
}
