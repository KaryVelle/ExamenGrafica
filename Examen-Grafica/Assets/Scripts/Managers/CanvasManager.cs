using TMPro;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private Canvas endCanvas;
    [SerializeField] private TMP_Text hudScoreText;
    [SerializeField] private TMP_Text finalScoreText;

    private void Awake()
    {
        endCanvas.gameObject.SetActive(false);
    }
    void OnEnable()
    {
        
    }
    void OnDisable()
    {
        
    }

    void ActivateCanvas()
    {
        
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