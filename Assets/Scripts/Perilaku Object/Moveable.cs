using UnityEngine;

public class Moveable : MonoBehaviour
{

    public Vector3 direction;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        updatePosition();
    }

    private void updatePosition()
    {
        transform.position = getNextPosition();
    }

    internal void setDirection(float x, float y)
    {
        direction.x = x;
        direction.y = y;
    }

    public Vector3 getNextPosition()
    {
        return transform.position + direction * Time.deltaTime * speed;
    }

    public void setDirection(Vector3 value)
    {
        direction = value;
    }
    public void setDirection(Vector2 value)
    {
        direction.x = value.x;
        direction.y = value.y;
    }

    internal void SetYDirection(float v)
    {
        direction.y = v;
    }

    internal void SetXDirection(float v)
    {
        direction.x = v;
    }
}
