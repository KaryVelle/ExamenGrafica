using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private ObjectPool pool;
    [SerializeField] private int initialCoins = 3;

    [Header("Área de juego (coordenadas del mundo)")]
    [SerializeField] private Vector2 minXZ = new Vector2(-10f, -10f);
    [SerializeField] private Vector2 maxXZ = new Vector2(10f, 10f);
    [SerializeField] private float spawnHeight = 1f;
    

    // TODO (Reactivo 2): maneja las monedas con el ObjectPool.
    //
    // El pool tiene dos métodos: Get(Vector3 position) y Return(GameObject obj).
    // Léelo antes de empezar (Assets/Scripts/Managers/ObjectPool.cs).
    //
    // 1. Al iniciar (Start), saca `initialCoins` monedas del pool.
    //    Cada una en una posición aleatoria dentro del área.
    //    Pista: Random.Range(min, max) para X y para Z, y spawnHeight para Y.
    public void start()

    {
        
    }

    private Vector3 RandomVecto3()
    {
        
        return new Vector3(Random.Range(minXZ.x, maxXZ.x), 0f);
    }

    // 2. Cuando una moneda sea recogida, regrésala al pool y saca otra
    //    en una nueva posición aleatoria.
    //    Pista: escucha el evento que creaste en Coin.
    //    El evento te da la moneda; el pool necesita su GameObject.
    // 3. Suscríbete en OnEnable y desuscríbete en OnDisable.
    //
    // PROHIBIDO: Instantiate y Destroy para las monedas.
    //
    // Extra opcional: OnDrawGizmosSelected para dibujar el área en la Scene view.
    private void Start()
    {
        
    }
}