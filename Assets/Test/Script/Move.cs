using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float jumpPower = 20f;

    private Rigidbody rb;
    private Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
      
    void Update()
    {
        PlayerMove();
    }

    private void PlayerMove()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        Vector3 Position = transform.position;

        Position.x += Horizontal * moveSpeed * Time.deltaTime;
        Position.z += Vertical * moveSpeed * Time.deltaTime;

        transform.position = Position;
    }
        
}
