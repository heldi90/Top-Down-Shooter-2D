using UnityEngine;

[RequireComponent(typeof(Moveable))]
public class MovementBoundary : MonoBehaviour
{

    private Moveable moveable;

    public Rect boundary;


    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        moveable = GetComponent<Moveable>();

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isXInBoundary())
        {
            moveable.SetXDirection(0f);
        }
        if (isYInBoundary())
        {
            moveable.SetYDirection(0f);
        }

    }

    private bool isYInBoundary()
    {
        return moveable.getNextPosition().y < boundary.yMin || moveable.getNextPosition().y > boundary.yMax;
    }

    private bool isXInBoundary()
    {
        return moveable.getNextPosition().x < boundary.xMin || moveable.getNextPosition().x > boundary.xMax;
    }
}
