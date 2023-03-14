using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public Transform respawnPoint;
    public float fallThreshold = -10f; 

    private void Update()
    {
        if (transform.position.y < fallThreshold)
        {
            Respawn();
        }
    }
    /*@Modified: Lainya 
    * Listens for trigger on end check point
    * */
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "EndCheckpoint") 
        {
            SceneManager.LoadScene("LevelComplete");
        }
    }

   /*@Modified: Sahil 
   * Respawns player if player object is outside map threshold
   * */
    private void Respawn()
    {
        transform.position = respawnPoint.position; 
        transform.rotation = respawnPoint.rotation; 
    }
}
