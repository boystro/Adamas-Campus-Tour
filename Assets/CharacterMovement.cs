using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 1f;
    
    private CharacterController characterController;
    private Vector3 movement = Vector3.zero;

    public void Start() {
        characterController = GetComponent<CharacterController>();
    }

    public void Update() {
        movement += 9.8f * Time.deltaTime * Vector3.down;
        characterController.Move(movement);
        movement = new Vector3(0, movement.y, 0);
    }

    public void Forward(float amount) {
        movement += amount * movementSpeed * transform.forward;
    }

    public void Right(float amount) {
        movement += amount * movementSpeed * transform.right;
    }
}
