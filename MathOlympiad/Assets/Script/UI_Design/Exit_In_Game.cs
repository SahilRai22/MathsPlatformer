using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit_In_Game : MonoBehaviour
{
    [SerializeField] private bool menuKeys = true;
    [SerializeField] private AudioSource bgm;//the backgroud music

    public GameObject menu_list;//the exit menu in game when click esc

   /*@Modified: Chaoran 
   * Listens for key Escape key triggers 
   * */
    void Update()
    {
        if (menuKeys)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
        {
                menu_list.SetActive(true);
                menuKeys = false;
                Time.timeScale = (0);//pause the game
                bgm.Pause();// pause the music
        }
            

        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            menu_list.SetActive(false);
            menuKeys = true;
            Time.timeScale = (1);//continue the game
            bgm.Pause();// continue the music

        }

    }

   /*@Modified: Chaoran 
   * Triggered when Continue button clicked
   * */
    public void Continue()//continue the game
    {
        menu_list.SetActive(false);
        menuKeys = true;
        Time.timeScale = (1);//continue the game
        bgm.Play();// continue the music

    }

    /*@Modified: Chaoran 
    * Triggered when Restart button clicked
    * */
    public void Restart()//restart this level 
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    /*@Modified: Chaoran 
    * Triggered when BackToMenu button clicked
    * */
    public void BackTomenu()//go back to the main menu 
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    /*@Modified: Chaoran 
    * Triggered when Exit button clicked
    * */
    public void Exit()//back to the main menu
    {
        Application.Quit();
    }

}

