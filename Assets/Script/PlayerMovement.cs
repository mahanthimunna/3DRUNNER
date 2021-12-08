using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;

    public float moveSpeed=3;
    public float leftrightSpeed = 4;
    public float jumpHeight;

    private Animator anim;
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();
    }
    void Update()
    {

        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > levelBoundary.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftrightSpeed);
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < levelBoundary.rightSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftrightSpeed * -1);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }  
    public void Jump()
    {
        anim.SetTrigger("Jump");
        //velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
    }
}
