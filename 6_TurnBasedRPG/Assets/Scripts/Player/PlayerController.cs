using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private Rigidbody2D myRigidbody;

    [Header("Public Values")]
    [SerializeField] private float moveSpeed = 4f;
    public float movePlayerHorizontal;
    public float movePlayerVertical;

    private Vector2 movement;

    private void Awake()
    {
        myRigidbody = (Rigidbody2D)GetComponent(typeof(Rigidbody2D));
    }

    private void Update()
    {
        

        movePlayerHorizontal = Input.GetAxisRaw("Horizontal");
        movePlayerVertical = Input.GetAxisRaw("Vertical");

        movement = new Vector2(movePlayerHorizontal, movePlayerVertical);

        myRigidbody.velocity = movement * moveSpeed;
    }

    
}
