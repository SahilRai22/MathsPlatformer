using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   
    private Rigidbody2D playerObj;
    [SerializeField] private float horizontalSpeed = 10; // SerializeField - allows to edit variable inside Unity (Easier testing)
    [SerializeField] private float verticalSpeed = 5;


    private Animator animate;
    private bool grounded;
    private GameObject playerObj1;  

    public PlayerMovement(GameObject playerObj1, float verticalSpeed)
    {
        this.playerObj1 = playerObj1;
        this.verticalSpeed = verticalSpeed;
    }



    /* @Modified: Sahil 
     * @Awake is called everytime script is loaded
     * Gets references from game object
     * */
    private void Awake()
    {
        playerObj = GetComponent<Rigidbody2D>();
        animate = GetComponent<Animator>();

    }

    /* @Modified: Sahil 
     * @Update checks method for every frame 
     * Listens for player inputs
     * */
    private void Update()
    {
        horizontalMovement();
        verticalMovement();
       
    }

    /* @Modified: Sahil
     * Input.GetAxis("Horizontal") - allows movement to left & right
     * Flips player when moving left using transform.localScale
     * */
    public void horizontalMovement()
    {
        float horzontalListener = Input.GetAxis("Horizontal");
        playerObj.velocity = new Vector3(Input.GetAxis("Horizontal") * horizontalSpeed, playerObj.velocity.y);

        if (horzontalListener > 0.01f)
        {
            moveRight();
        }

        else if (horzontalListener < -0.01f)
        {
            moveLeft();
        }


        //set animation parameter from animator window when key is pressed 
        animate.SetBool("run", horzontalListener != 0);

    }
    
    public void moveLeft()
    {
 
        transform.localScale = new Vector3(-2, 2, 2);
    }

    public void moveRight()
    {
        transform.localScale = new Vector3(2, 2, 2); ;
    }


    /* @Modified: Sahil
     * key listener for space to jump
     * */
    public void verticalMovement()
    { 
        if (Input.GetKey(KeyCode.Space) && grounded)
        {
            playerJump();
            grounded = false;
            animate.SetTrigger("jump");
        }
        animate.SetBool("grounded", grounded);
    }

    public void playerJump()
    {
        playerObj.velocity = new Vector2(playerObj.velocity.x, verticalSpeed);
        
    }


    /* @Modified: Sahil
     * Called when stopped touching another rigid body
     * **/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }

}







