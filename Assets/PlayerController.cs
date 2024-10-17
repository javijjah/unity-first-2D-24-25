using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 2.0f;
    [SerializeField] private float jumpForce = 5.0f;

    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rigidBody2D;
    private bool onFloor = false;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputAxis = Input.GetAxis("Horizontal");
        transform.position += new Vector3(inputAxis * Time.deltaTime * speed,
                                          0, 0);
        spriteRenderer.flipX = inputAxis == .0f? spriteRenderer.flipX : inputAxis > 0;

        var rayCast = Physics2D.Raycast(transform.position - (transform.up * 1.1f),
                                        -transform.up , .1f);
        if(rayCast.collider != null) onFloor = true;
            else onFloor = false;

        if (onFloor && Input.GetButtonDown("Jump"))
        {
            rigidBody2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            onFloor = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.tag == "Floor")
        //    onFloor = true;
    }
}
