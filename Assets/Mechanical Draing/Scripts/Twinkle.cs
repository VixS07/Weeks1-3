using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UIElements;

public class Twinkle : MonoBehaviour
{
    public AnimationCurve curve;
    public float t;
    public bool hi;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //update the time in seconds
        t += Time.deltaTime;

        //get the possition
        Vector2 newPos = transform.position;
        //set the bottom left and bottom right to account for gamescreen size changes
        //got it from the FirstScript script
        bottomLeft = Camera.main.ScreenToWorldPoint(Vector2.zero);
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        //reset the time every 5 seconds to allow for a loop
        if (t > 5) {
            t = 0;
            //change the position to a random area within the screen
            //im doing unit circle because im not sure how to combine random with world screen position
            //if it works it works :')
            newPos = Random.insideUnitCircle * 10;

            //I was going to do this but I think we did something like this in class week 3 and I dont want to risk it lol

            //Random.Range
        }

        //check to see if star has moved off screen, if it has bring it to the edge of the screen it went over.
        //x axis
        //left side
        if (newPos.x < 0)
        {
            newPos.x = bottomLeft.x;
        }
        //right side
        else if (newPos.x > Screen.width)
        {
            newPos.x = topRight.x;
        }
        //y axis
        //top
        else if (newPos.y < 0) {
            newPos.y = bottomLeft.x
        }
        else if (newPos.y > Screen.height)
        {
            newPos.y = topRight.y;
        }

        //change the scale of the star using the animation curve based on time.
        //got from the Pulse script
        transform.localScale = Vector3.one * curve.Evaluate(t);

    }
}
