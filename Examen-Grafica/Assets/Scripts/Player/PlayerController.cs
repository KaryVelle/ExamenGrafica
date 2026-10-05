using UnityEngine;

[RequireComponent(typeof(PlayerInputReader))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private Transform cameraTransform;

    private PlayerInputReader inputReader;
    private IMovable movable;
    private ILookable lookable;

    // TODO (Reactivo 1): conecta el salto.
    //
    // 1. Crea la interfaz IJumpable en su propio archivo (mira IMovable como ejemplo).
    // 2. Aquí obtén un IJumpable igual que se obtiene el IMovable.
    //    OJO: este script solo puede conocer la INTERFAZ, nunca PlayerMovement.
    // 3. Cuando el InputReader avise que se presionó el salto, llama al salto.
    //    Pista: suscríbete al evento que creaste en PlayerInputReader.
    //    ¿Dónde se suscribe y dónde se desuscribe? (piensa en OnEnable / OnDisable)

    void Awake()
    {
        inputReader = GetComponent<PlayerInputReader>();
        movable = GetComponent<IMovable>();
        lookable = cameraTransform.GetComponent<ILookable>();
    }

    void Update()
    {
        lookable.Look(inputReader.LookInput);

        Vector2 direction = CameraRelative(inputReader.MoveInput);
        movable.Move(direction);
    }

    private Vector2 CameraRelative(Vector2 input)
    {
        Vector3 forward = cameraTransform.forward;
        forward.y = 0f;
        forward.Normalize();

        Vector3 right = cameraTransform.right;
        right.y = 0f;
        right.Normalize();

        Vector3 world = forward * input.y + right * input.x;
        return new Vector2(world.x, world.z);
    }
}