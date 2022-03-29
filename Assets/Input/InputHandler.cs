using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;


[CreateAssetMenu(fileName = "Input Handler", menuName = "Input Handler")]
public class InputHandler : ScriptableObject, CustomInput.IGamePlayActions
{
    private CustomInput input;
    public UnityAction<Vector2> OnSetDirectionAction;
    private void OnEnable()
    {
        if (input == null)
        {
            input = new CustomInput();
        }

        input.GamePlay.SetCallbacks(this);
        input.GamePlay.Enable();
    }

    private void onDisable()
    {
        input.GamePlay.Disable();
    }

    public void OnSetDirection(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed || context.phase == InputActionPhase.Canceled)
        {
            OnSetDirectionAction?.Invoke(context.ReadValue<Vector2>());
        }
    }
}
