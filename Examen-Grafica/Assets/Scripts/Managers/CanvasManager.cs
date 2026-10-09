using System;
using TMPro;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private Canvas endCanvas;
    [SerializeField] public TMP_Text hudScoreText;
    [SerializeField] private TMP_Text finalScoreText;

    // TODO (Reactivo 4): controla la UI.
    //
    // 1. Al iniciar, la pantalla final debe estar oculta.
  
    // 2. Escucha los eventos del GameManager:
    public void updateScore(int score)
    {
        hudScoreText.text += score.ToString();
    }

    private void OnEnable()
    {
        
        endCanvas.enabled = false;
    }

    private void OnDisable()
    {
        endCanvas.enabled = true;
    }
    //    - Cuando cambie el puntaje: actualiza el texto del HUD.
    //    - Cuando se gane: muestra el puntaje final y la pantalla final.
    //    Suscríbete en OnEnable y desuscríbete en OnDisable.
    
    // 3. Mostrar/ocultar se hace con la propiedad `enabled` del Canvas.
    //    PROHIBIDO usar SetActive para esto.
    // 4. Para poder hacer clic en el botón necesitas el cursor visible y libre.
    //    Pista: Cursor.lockState y Cursor.visible.
}