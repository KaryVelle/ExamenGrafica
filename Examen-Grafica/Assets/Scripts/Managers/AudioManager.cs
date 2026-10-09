using System;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioClip coinClip;
    private AudioSource audioSource;
    // TODO (Reactivo 5): reproduce el sonido cada vez que se recoge una moneda.
    //
    // 1. Obt�n el AudioSource (RequireComponent ya garantiza que existe).
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        Coin.OnCollectCoin += PlayCoinSound;
    }

    private void OnDisable()
    {
        Coin.OnCollectCoin -= PlayCoinSound;     
    }

    private void PlayCoinSound(Coin obj)
    {
        audioSource.PlayOneShot(coinClip);
    }
    // 2. Escucha el evento de moneda recogida.
    //    Suscr�bete en OnEnable y desuscr�bete en OnDisable.
    // 3. Al recibir el evento, reproduce `coinClip`.
    //    Pista: si recoges monedas muy r�pido, el sonido no debe cortarse.
    //    Hay un m�todo de AudioSource que lanza un clip sin interrumpir los dem�s.
    //
    // REGLA: nadie llama al AudioManager directamente. Solo escucha.
}