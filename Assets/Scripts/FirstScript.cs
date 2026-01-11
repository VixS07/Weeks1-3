using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public float speed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //speed = Random.Range(0.01f, 0.1f);
        transform.position = (Vector2)transform.position + Random.insideUnitCircle * 2 ;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        newPos.x += speed * Time.deltaTime;
        transform.position = newPos;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        if(screenPos.x < 0 || screenPos.x> Screen.width)
        {
            speed = speed * -1;
            if (screenPos.x < 0)
            {
                screenPos.x = 0;
            }
            else 
            { 
                screenPos.x = Screen.width;
            }

        }

    }
}
