﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeMove : MonoBehaviour
{

	public CharacterController controller;

	public float gravity = -9.81f;

	public float speed = 12f;
 
    public Transform GroundC;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float JumpHeight = 3f;


	Vector3 velocity;
	bool isGrounded;

    void Update()
    {
        isGrounded = Physics.CheckSphere(GroundC.position, groundDistance, groundMask);
        if(isGrounded && velocity.y < 0){

        	velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
        	velocity.y = Mathf.Sqrt(JumpHeight * -2 * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);


    }
}
