using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public static PlayerController instance;
    public string areaTransitionName;
    
    private Rigidbody2D myRigidbody;
    private Animator playerAnim;

    [Header("Public Values")]
    [SerializeField] private float moveSpeed = 4f;
    private float movePlayerHorizontal;//********* X Axis
    private float movePlayerVertical; //********** Y Axis

    private Vector2 movement;
 

    //TODO add polygon collider onexit and have player respawn in map
    private void Awake()
    {

        if (instance == null)
        {
            instance = this;
        } else
        {
            Destroy(gameObject);
        }

        myRigidbody = (Rigidbody2D)GetComponent(typeof(Rigidbody2D));
        playerAnim = (Animator)GetComponent(typeof(Animator));
    }
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        
        //Movement Work
        movePlayerHorizontal = Input.GetAxisRaw("Horizontal");
        movePlayerVertical = Input.GetAxisRaw("Vertical");

        movement = new Vector2(movePlayerHorizontal, movePlayerVertical);

        myRigidbody.velocity = movement * moveSpeed;

       

        //Animation Work
        playerAnim.SetFloat("moveX", myRigidbody.velocity.x);
        playerAnim.SetFloat("moveY", myRigidbody.velocity.y);

        if(Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            playerAnim.SetFloat("Horizontal", Input.GetAxisRaw("Horizontal"));
            playerAnim.SetFloat("Vertical", Input.GetAxisRaw("Vertical"));
        }
    }

    
}
