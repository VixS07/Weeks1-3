using UnityEngine;
using UnityEngine.InputSystem;

public class TankSpawner : MonoBehaviour
{
    public GameObject tankPrefab; 

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

            Vector2 spawnPos = Random.insideUnitCircle * 3; 
            //Quaternion.identity means no rotation which the same same as Euler angles (0,0,0)
            Instantiate(tankPrefab, spawnPos, Quaternion.identity);
        }

        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            //Instantiate a prefab, a Transform: makes it appear at 0,0 as the child of that transform
            Instantiate(tankPrefab, transform);

        }
    }
}
