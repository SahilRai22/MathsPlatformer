using UnityEngine;
using UnityEngine.SceneManagement;


public class StartGame : MonoBehaviour
{
    public GameObject settingsCanvas;
    /*@Modified: Chaoran 
    * Triggered when Start button clicked
    * */
    public void StartMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    /*@Modified: Sahil 
    * Debug checker to quit game / actualy way to quit 
    * */
    public void QuitGame()
    {
        Debug.Log("game quit");
        Application.Quit();
    }
    /*@Modified: Chaoran 
    * Triggered when Instruction button clicked
    * */
    public void ShowInstructions()
    {
        //settingsCanvas.enabled = !settingsCanvas.enabled;
        settingsCanvas.SetActive(!settingsCanvas.activeSelf);
    }
}
