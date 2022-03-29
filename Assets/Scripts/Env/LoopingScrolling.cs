using UnityEngine;

public class LoopingScrolling : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] bg;
    public float speed;

    public float cek;

    private Vector3 direction;
    void Start()
    {
        direction = new Vector3(0, -1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        posisiUpdate();
        cekPosisi();
    }

    void posisiUpdate()
    {
        bg[0].position += direction * Time.deltaTime * speed;
        bg[1].position += direction * Time.deltaTime * speed;
    }

    void cekPosisi()
    {
        if (bg[0].position.y <= -cek)
        {
            moveToTop(0, 1);
        }
        if (bg[1].position.y <= -cek)
        {
            moveToTop(1, 0);
        }

    }

    void moveToTop(int index, int index2)
    {
        bg[index].position = bg[index2].position + new Vector3(0, cek, 0);
    }
}
