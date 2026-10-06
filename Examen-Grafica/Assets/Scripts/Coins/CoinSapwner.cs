using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private ObjectPool pool;
    [SerializeField] private int initialCoins = 3;

    [Header("�rea de juego (coordenadas del mundo)")]
    [SerializeField] private Vector2 minXZ = new Vector2(-10f, -10f);
    [SerializeField] private Vector2 maxXZ = new Vector2(10f, 10f);
    [SerializeField] private float spawnHeight = 1f;

    // TODO (Reactivo 2): maneja las monedas con el ObjectPool.
    //
    // El pool tiene dos m�todos: Get(Vector3 position) y Return(GameObject obj).
    // L�elo antes de empezar (Assets/Scripts/Managers/ObjectPool.cs).
    //
    // 1. Al iniciar (Start), saca `initialCoins` monedas del pool.
    //    Cada una en una posici�n aleatoria dentro del �rea.
    //    Pista: Random.Range(min, max) para X y para Z, y spawnHeight para Y.
    // 2. Cuando una moneda sea recogida, regr�sala al pool y saca otra
    //    en una nueva posici�n aleatoria.
    //    Pista: escucha el evento que creaste en Coin.
    //    El evento te da la moneda; el pool necesita su GameObject.
    // 3. Suscr�bete en OnEnable y desuscr�bete en OnDisable.
    //
    // PROHIBIDO: Instantiate y Destroy para las monedas.
    //
    // Extra opcional: OnDrawGizmosSelected para dibujar el �rea en la Scene view.

    void start()
    {
        pool.Get(new Vector3(Random.Range(minXZ.x, maxXZ.x), spawnHeight, Random.Range(minXZ.y, maxXZ.y)));
        

        return;
    }
}