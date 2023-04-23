using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpforce = 10f;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;
    public LayerMask deathLayer;
    private bool isDead;
    private Vector3 startPosition;
    private Rigidbody2D rb;

    void Awake()
    {
        startPosition = transform.position;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    [SerializeField] private AudioSource jumpSoundEffect;


    // Update is called once per frame
    void Update()
    {
        isDead = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, deathLayer);
        if(isDead)
        {
            transform.position = startPosition;
            return;
        }
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        if (Input.GetKey(KeyCode.D)) rb.AddForce(Vector2.right * speed * Time.deltaTime, ForceMode2D.Impulse);
        if (Input.GetKey(KeyCode.A)) rb.AddForce(Vector2.left * speed * Time.deltaTime, ForceMode2D.Impulse);
        if (Input.GetKey(KeyCode.Space) && isTouchingGround) {
            jumpSoundEffect.Play();
            rb.velocity = new Vector2(rb.velocity.x, 1 * jumpforce);    
        }
    }
}
