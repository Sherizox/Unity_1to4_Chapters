using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private Animator animator;
    public float jumpForce = 15f;
    public float gravityModifier = 2f;
    private int jumpCount = 0;
    private bool isOnSurface = true;
    public bool gameOver = false;

    public AudioClip jumpAudio;
    public AudioClip crashAudio;
    private AudioSource playerAudio;

    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        Physics.gravity *= gravityModifier;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !gameOver && (isOnSurface || jumpCount < 2))
        {
            rb.velocity = new Vector3(0, jumpForce, 0); 
            jumpCount++;
            isOnSurface = false; 
            animator.SetTrigger("Jump_trig");
            dirtParticle.Stop();
            playerAudio.PlayOneShot(jumpAudio);
            Debug.Log("Jumped, count: " + jumpCount);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnSurface = true;
            jumpCount = 0;
            dirtParticle.Play();

            
        }

       
        if (collision.gameObject.CompareTag("Obstacle") && !gameOver)
        {
            gameOver = true;
            animator.SetBool("Death_b", true);
            animator.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            dirtParticle.Stop();
            playerAudio.PlayOneShot(crashAudio);

        
        }
    }
}
