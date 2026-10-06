using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public event Action  OnChangeScore;
    public event Action  OnWinGame;
    
    [SerializeField] private int coinsToWin = 3;
    [SerializeField] private int pointsPerCoin = 10;
    private int totalPoints = 0;
    private int totalCoins = 0;
    private bool isAllCoinsCollected = false;
    
    public int TotalPoints => totalPoints;
    private void OnEnable()
    {
        Coin.OnCollectCoin += AddPoints;
    }

    private void OnDisable()
    {
        Coin.OnCollectCoin -= AddPoints;   
    }

    private void AddPoints(Coin obj)
    {
            
        if (totalCoins >= coinsToWin)
        {
            isAllCoinsCollected = true;
            OnWinGame?.Invoke();
        }
        if (!isAllCoinsCollected)
        {
            totalPoints += pointsPerCoin;
            totalCoins++;
            OnChangeScore?.Invoke();
        }
            
    }
    
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

    public void RestartGame()
    {
        int indexActualScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(indexActualScene);
    }
}