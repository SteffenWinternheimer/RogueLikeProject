using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D rigidbody2D;
    public Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveCharacter(movement);
    }

    public void MoveCharacter(Vector2 direction)
    {
        rigidbody2D.MovePosition((Vector2)transform.position + (direction * movementSpeed * Time.deltaTime));
    }
}
