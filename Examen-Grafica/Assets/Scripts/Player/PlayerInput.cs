using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputReader : MonoBehaviour
{
    public Vector2 MoveInput { get; private set; }
    public Vector2 LookInput { get; private set; }

    // TODO (Reactivo 1): agrega el salto a este script.
    //
    // Pasos:
    // 1. Obtén la acción en Awake, igual que Move y Look.
    // 3. Este script NO debe saltar: solo debe AVISAR que se presionó el botón.
    //    Declara un evento público para eso.
    //    Pista: InputAction tiene un evento llamado `performed`.
    // 4. Lo que te suscribes en OnEnable, lo desuscribes en OnDisable.

    private InputAction moveAction;
    private InputAction lookAction;

    void Awake()
    {
        PlayerInput playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions["Move"];
        lookAction = playerInput.actions["Look"];
    }

    void OnEnable()
    {
        moveAction.Enable();
        lookAction.Enable();
    }

    void OnDisable()
    {
        moveAction.Disable();
        lookAction.Disable();
    }

    void Update()
    {
        MoveInput = moveAction.ReadValue<Vector2>();
        LookInput = lookAction.ReadValue<Vector2>();
    }
}