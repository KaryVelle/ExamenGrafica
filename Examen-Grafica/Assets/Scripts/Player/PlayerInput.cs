using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputReader : MonoBehaviour
{
    public Vector2 MoveInput { get; private set; }
    public Vector2 LookInput { get; private set; }
    
    // TODO (Reactivo 1): agrega el salto a este script.
    //
    // Pasos:
    // 1. Obt�n la acci�n en Awake, igual que Move y Look.
    // 3. Este script NO debe saltar: solo debe AVISAR que se presion� el bot�n.
    //    Declara un evento p�blico para eso.
    //    Pista: InputAction tiene un evento llamado `performed`.
    // 4. Lo que te suscribes en OnEnable, lo desuscribes en OnDisable.

    private PlayerMovement playerMovement;
    private InputAction moveAction;
    private InputAction lookAction;
    private InputAction jumpAction;

    void Awake()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
        PlayerInput playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions["Move"];
        lookAction = playerInput.actions["Look"];
        jumpAction = playerInput.actions["Jump"];
    }
    void OnEnable()
    {
        moveAction.Enable();
        lookAction.Enable();
        jumpAction.performed += Jump;
    }
    void OnDisable()
    {
        moveAction.Disable();
        lookAction.Disable();
        jumpAction.performed += Jump;
    }
    void Update()
    {
        MoveInput = moveAction.ReadValue<Vector2>();
        LookInput = lookAction.ReadValue<Vector2>();
    }
    private void Jump(InputAction.CallbackContext obj)
    {
        playerMovement.Jump();
    }
}
