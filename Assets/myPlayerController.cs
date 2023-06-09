using UnityEngine;

public class myPlayerController : MonoBehaviour
{

    public float speed;
    public float jumpforce;
    public Rigidbody2D rb;
    public bool isGrounded;

    public float Coin { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        isGrounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        //If key "A" pressed
        if (Input.GetKey(KeyCode.A))
        {
            //move player left by "speed"
            rb.AddForce(Vector2.left * speed);

        }
        //If key "D" pressed
        if (Input.GetKey(KeyCode.D))
        {
            //move player right by "speed"
            rb.AddForce(Vector2.right * speed);

        }
        //if space pressed while touching ground
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            //jump
            rb.AddForce(Vector2.up * jumpforce);
        }
    }

    //Collision Detect
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "coinPickup")
        {
            //Destroy objects
            Destroy(col.gameObject);

        }

    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "ground")
        {
            isGrounded = true;
        }
    }

    //private void (Collider2D col)
    //{
    //if (col.gameObject.tag == "ground")
    //{
    // isGrounded = true;
    //}
    //}

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "ground")
        {
            isGrounded = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "jumpPad")
        {
            rb.AddForce(Vector2.up * jumpforce * 2);
        }
    }
}
