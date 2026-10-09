using UnityEngine;

public class GameManager : MonoBehaviour
{
    private CoinSpawner coinSpawner;
    [SerializeField] private int coinsToWin = 10;
    [SerializeField] private int pointsPerCoin = 10;

    // TODO (Reactivo 3): lleva la cuenta del juego.
    //
    // 1. Escucha el evento de moneda recogida (el de Coin).
    //    Suscr�bete en OnEnable, desuscr�bete en OnDisable.
    // 2. Cada moneda suma `pointsPerCoin` al puntaje y 1 al contador de monedas.
    // 3. Cuando el contador llegue a `coinsToWin`, el juego termina.
    // 4. Una vez terminado, las monedas ya no suman nada.
    //    Pista: una variable bool de estado.
    // 5. El GameManager no toca la UI. Para avisar los cambios, declara tus
    //    propios eventos (uno cuando cambia el puntaje y uno cuando se gana).
    //    El CanvasManager los escuchar�.
    //
    // TODO (Reactivo 4): implementa RestartGame().
    //    Est� conectado al bot�n de la pantalla final desde el Inspector.
    //    Pista: SceneManager.LoadScene (necesita using UnityEngine.SceneManagement).
    //    Pista 2: SceneManager.GetActiveScene() te dice la escena actual.
    private void OnEnable()
    {
        
    }
    private void OnDisable()
    {
        
    }
    void MonedaRecogida()
    {
        coinSpawner.RecogerMoneda();
    }
    public void RestartGame()
    {
        // TODO
    }
}