using Unity.Mathematics.Geometry;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour, IMovable, IJumpable
{
    public float speed = 6f;
    public float gravity = -20f;
    public float jumpHeight = 2f;
    // TODO (Reactivo 1): haz que esta clase tambi�n implemente IJumpable.
    //
    // - Agrega un campo p�blico para la altura del salto (por ejemplo jumpHeight).

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
    // - Implementa el m�todo Jump().
    // - Solo se puede saltar si el personaje est� en el suelo.
    //   Pista: CharacterController tiene una propiedad que lo indica.
    // - El salto consiste en darle una velocidad vertical inicial hacia arriba.
    //   Pista de f�sica: v = sqrt(altura * -2 * gravedad)
    //   Ya existe una variable que guarda la velocidad vertical. �sala.

    public void Jump()
    {
        if (controller.isGrounded)
        {
            verticalVelocity = Mathf.Sqrt(jumpHeight *-2* gravity );
        }
    }
}