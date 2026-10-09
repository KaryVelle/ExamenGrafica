using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public interface IJumpable
{
    void Jump(InputAction.CallbackContext context);
}
