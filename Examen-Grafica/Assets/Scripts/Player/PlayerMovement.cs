using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour, IMovable,  IJumpable
{
    public float speed = 6f;
    public float gravity = -20f;
    public float jumpHeight = 12f;

    // TODO (Reactivo 1): haz que esta clase también implemente IJumpable.
    //
    // - Agrega un campo público para la altura del salto (por ejemplo jumpHeight).
    // - Implementa el método Jump().
    // - Solo se puede saltar si el personaje está en el suelo.
    //   Pista: CharacterController tiene una propiedad que lo indica.
    // - El salto consiste en darle una velocidad vertical inicial hacia arriba.
    //   Pista de física: v = sqrt(altura * -2 * gravedad)
    //   Ya existe una variable que guarda la velocidad vertical. Úsala.

    private CharacterController controller;
    private float verticalVelocity;

    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    public void Move(Vector2 direction)
    {
        if (controller.isGrounded && verticalVelocity < 0f)
            verticalVelocity = -2f;

        verticalVelocity += gravity * Time.deltaTime;

        Vector3 movement = new Vector3(direction.x, 0f, direction.y) * speed;
        movement.y = verticalVelocity;

        controller.Move(movement * Time.deltaTime);
    }

    public void Jump(InputAction.CallbackContext  context)
    {
        if (controller.isGrounded)
        {
            Debug.Log("jump");
            verticalVelocity = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }
    }
}