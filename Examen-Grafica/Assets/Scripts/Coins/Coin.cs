using System;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // TODO (Reactivo 6): avisa que la moneda fue recogida.
    //
    // - Declara un evento público y estático que lleve la moneda como dato
    //   (pista: Action<Coin>). Así cualquiera puede escucharlo sin referenciar la moneda.
    // - Dispáralo dentro de OnTriggerEnter.
    //
    // REGLA: esta clase NO puede mencionar a GameManager, AudioManager,
    // CanvasManager ni CoinSpawner. Solo avisa; no sabe quién escucha.
    //
    // Pista: usa el operador ?. al invocar el evento por si nadie escucha.

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
        // TODO: dispara el evento aquí
        public Action<CoinSpawner> OnCoinSpawner;
        return;
        }
    }

}