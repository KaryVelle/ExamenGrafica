using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioClip coinClip;

    // TODO (Reactivo 5): reproduce el sonido cada vez que se recoge una moneda.
    //
    // 1. Obtén el AudioSource (RequireComponent ya garantiza que existe).
    // 2. Escucha el evento de moneda recogida.
    //    Suscríbete en OnEnable y desuscríbete en OnDisable.
    // 3. Al recibir el evento, reproduce `coinClip`.
    //    Pista: si recoges monedas muy rápido, el sonido no debe cortarse.
    //    Hay un método de AudioSource que lanza un clip sin interrumpir los demás.
    //
    // REGLA: nadie llama al AudioManager directamente. Solo escucha.
}