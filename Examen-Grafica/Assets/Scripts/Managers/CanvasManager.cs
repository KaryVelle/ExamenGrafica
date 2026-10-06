using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private Canvas endCanvas;
    [SerializeField] private TMP_Text hudScoreText;
    [SerializeField] private TMP_Text finalScoreText;

    private GameManager gameManager;
    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>() as GameManager;
    }
    
    private void OnEnable()
    {
        gameManager.OnWinGame += ActiveEndScreen;
        gameManager.OnChangeScore += UpdateTextScore;
    }

    private void OnDisable()
    {
     gameManager.OnWinGame -= ActiveEndScreen;
     gameManager.OnChangeScore -= UpdateTextScore;
    }

    private void UpdateTextScore()
    {
        Debug.Log("UpdateTextScore");
        Debug.Log(gameManager.TotalPoints);
        hudScoreText.text = gameManager.TotalPoints.ToString();
    }

    private void ActiveEndScreen()
    {
        endCanvas.enabled = true;
        finalScoreText.text = gameManager.TotalPoints.ToString();
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    private void Start()
    {
        endCanvas.enabled = false;
        finalScoreText.text = gameManager.TotalPoints.ToString();
    }
    
    
    // TODO (Reactivo 4): controla la UI.
    //
    // 1. Al iniciar, la pantalla final debe estar oculta.
    // 2. Escucha los eventos del GameManager:
    //    - Cuando cambie el puntaje: actualiza el texto del HUD.
    //    - Cuando se gane: muestra el puntaje final y la pantalla final.
    //    Suscr�bete en OnEnable y desuscr�bete en OnDisable.
    // 3. Mostrar/ocultar se hace con la propiedad `enabled` del Canvas.
    //    PROHIBIDO usar SetActive para esto.
    // 4. Para poder hacer clic en el bot�n necesitas el cursor visible y libre.
    //    Pista: Cursor.lockState y Cursor.visible.
}