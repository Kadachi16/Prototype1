using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 10f;
    private float rotationSpeed = 100f;
    public float verticalInput;

    void Start()
    {

    }

    void FixedUpdate()
    {
        // input do jogador
        verticalInput = Input.GetAxis("Vertical");

        // mover para frente
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // inclinar usando input
        transform.Rotate(Vector3.right * rotationSpeed * verticalInput * Time.deltaTime);
    }
}