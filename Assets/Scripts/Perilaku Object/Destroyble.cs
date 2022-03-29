using UnityEngine;

public class Destroyble : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void destroyObject()
    {
        Destroy(gameObject);
    }
}
