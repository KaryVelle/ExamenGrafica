using System;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioClip coinClip;
    [SerializeField] private AudioSource audioClip;

    // TODO (Reactivo 5): reproduce el sonido cada vez que se recoge una moneda.
    //
    // 1. Obt�n el AudioSource (RequireComponent ya garantiza que existe).
    
    // 2. Escucha el evento de moneda recogida.
    //    Suscr�bete en OnEnable y desuscr�bete en OnDisable.
    private void OnEnable()
    {
        Coin.CoinColleted += CoinColleted;
        AudioSource.Instantiate(audioClip);
    }
    void CoinColleted(Coin obj)
    {
        throw new NotImplementedException();
    }

    private void OnDisable()
    {
        Coin.CoinColleted += CoinColleted;
    }
    // 3. Al recibir el evento, reproduce `coinClip`.
    //    Pista: si recoges monedas muy r�pido, el sonido no debe cortarse.
    //    Hay un m�todo de AudioSource que lanza un clip sin interrumpir los dem�s.
    //
    // REGLA: nadie llama al AudioManager directamente. Solo escucha.
}