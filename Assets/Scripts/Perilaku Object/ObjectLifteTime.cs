using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class ObjectLifteTime : MonoBehaviour

{


    public float lifeTime;

    private float timer;

    public UnityEvent OnTimerReachedZero;
    // Start is called before the first frame update
    void Start()
    {
        timer = lifeTime;

        StartCoroutine(ObjectTimer());
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < 0)
        {
            OnTimerReachedZero?.Invoke();
        }



        timer -= Time.deltaTime;
    }

    private IEnumerator ObjectTimer()
    {
        Color defaulColor = GetComponent<SpriteRenderer>().color;
        Color blinkColor = defaulColor;
        blinkColor.a = 0.5f;

        yield return new WaitForSeconds(lifeTime * 0.7f);
        while (timer > 0)
        {
            GetComponent<SpriteRenderer>().color = blinkColor;
            yield return new WaitForSeconds(0.1f);
            GetComponent<SpriteRenderer>().color = defaulColor;
            yield return new WaitForSeconds(0.1f);

        }
    }
}
