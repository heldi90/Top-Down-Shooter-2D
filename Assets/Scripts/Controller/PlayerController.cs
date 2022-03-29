using UnityEngine;


[RequireComponent(typeof(Moveable))]
public class PlayerController : MonoBehaviour
{
    public InputHandler input;
    // Start is called before the first frame update
    private Moveable moveable;
    void Awake()
    {
        moveable = GetComponent<Moveable>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnSetDirection(Vector2 direction)
    {
        moveable.setDirection(direction);
    }

    private void OnEnable()
    {
        input.OnSetDirectionAction += OnSetDirection;
    }


    void OnDisable()
    {
        input.OnSetDirectionAction -= OnSetDirection;
    }
}
