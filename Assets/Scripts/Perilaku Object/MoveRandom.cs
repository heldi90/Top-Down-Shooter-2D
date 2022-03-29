using UnityEngine;

[RequireComponent(typeof(Moveable))]
public class MoveRandom : MonoBehaviour
{
    private Moveable moveable;

    private void Awake()
    {
        moveable = GetComponent<Moveable>();
    }
    // Start is called before the first frame update
    void Start()
    {
        moveable.setDirection(randomDirection(), randomDirection());
    }

    // Update is called once per frame
    void Update()
    {

    }

    float randomDirection()
    {
        return Random.Range(-1f, 1);
    }
}
