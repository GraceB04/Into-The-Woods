using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;
    private Animator anim;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

        //flip player when moving left and right
        if (horizontalInput > 0.01F)
            transform.localScale = new Vector3(9, 9, 9);
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-9, 9, 9);

        anim.SetBool("Run", horizontalInput != 0);

    }
}