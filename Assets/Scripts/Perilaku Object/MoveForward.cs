using UnityEngine;

[RequireComponent(typeof(Moveable))]
public class MoveForward : MonoBehaviour
{

    private Moveable moveable;


    private void Awake()
    {
        moveable = GetComponent<Moveable>();
    }
    // Start is called before the first frame update
    void Start()
    {
        moveable.setDirection(transform.up);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
