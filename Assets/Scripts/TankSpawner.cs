using UnityEngine;
using UnityEngine.InputSystem;

public class TankSpawner : MonoBehaviour
{
    public GameObject tankPrefab;
    public int numberOfTanks = 0;
    public GameObject spawnedTank;

    public FirstScript tanksScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            //Instantiate a prefab: ,ake this one appear.
            //Instantiate a prefab, a Vector 2 or Vector 3, a Quaternion : make it appear at this position and rotation
            //USE THIS ONE
            //Instantiate(tankPrefab, transform.position, transform.rotation);

            Vector2 spawnPos = Random.insideUnitCircle * 5; 
            //Quaternion.identity means no rotation which the same same as Euler angles (0,0,0)
            spawnedTank = Instantiate(tankPrefab, spawnPos, Quaternion.identity);

            tanksScript = spawnedTank.GetComponent<FirstScript>();

            numberOfTanks++;

            tanksScript.speed = numberOfTanks;
            //tanksScript.body.color = Random.ColorHSV();
        }

        //if (Mouse.current.rightButton.wasPressedThisFrame)
        //{
        //    //Instantiate a prefab, a Transform: makes it appear at 0,0 as the child of that transform
        //    Instantiate(tankPrefab, transform);

        //}
    }
}
