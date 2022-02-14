using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class PlayerMove : NetworkBehaviour
{
    [SerializeField] float movementSpeed = 5f;
    CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsOwner)
        {
            Vector3 movementDirection = Vector3.zero;

            if (Input.GetKey(KeyCode.W))
            {
                movementDirection.z++;
            }

            if (Input.GetKey(KeyCode.A))
            {
                movementDirection.x--;
            }

            if (Input.GetKey(KeyCode.S))
            {
                movementDirection.z--;
            }

            if (Input.GetKey(KeyCode.D))
            {
                movementDirection.x++;
            }

            transform.LookAt(transform.position + movementDirection);
            //transform.localPosition += movementDirection * Time.deltaTime * movementSpeed;

            characterController.Move(movementDirection * movementSpeed * Time.deltaTime);
        }
    }
}
