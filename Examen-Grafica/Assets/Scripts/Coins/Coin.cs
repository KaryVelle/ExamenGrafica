using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // TODO (Reactivo 6): avisa que la moneda fue recogida.
    //
    // - Declara un evento p�blico y est�tico que lleve la moneda como dato
    //   (pista: Action<Coin>). As� cualquiera puede escucharlo sin referenciar la moneda.
    // - Disp�ralo dentro de OnTriggerEnter.
    //
    // REGLA: esta clase NO puede mencionar a GameManager, AudioManager,
    // CanvasManager ni CoinSpawner. Solo avisa; no sabe qui�n escucha.
    //
    // Pista: usa el operador ?. al invocar el evento por si nadie escucha.
    public static Action<Coin> CoinColleted;

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        CoinColleted?.Invoke(this);

        // TODO: dispara el evento aqu�
    }
}