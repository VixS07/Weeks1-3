using UnityEngine;

public class Teleport : MonoBehaviour
{

    float t;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        if (t >= 3) {
            t = 0;

            Vector2 newPos = Random.insideUnitCircle * 2;


            transform.position = newPos;


        }
    }
}
