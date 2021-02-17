using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObject : MonoBehaviour, IMixedRealityInputHandler
{
    bool carrying;
    GameObject carriedObject;
    Camera camera;
    //public float distances;
    //public float smooth;
    Vector3 initialPosition;
    Vector3 currentPosition;
    Vector3 movementDirection;

    void Awake()
    {
        initialPosition = transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        //camera = GameObject.Find("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnInputUp(InputEventData eventData)
    {
        transform.GetComponent<Rigidbody>().isKinematic = false;

        currentPosition = transform.position;

        Vector3 direction = (currentPosition - initialPosition).normalized;

        //transform.GetComponent<Rigidbody>().AddForce(new Vector3(- (direction.x * 5f), Mathf.Abs(direction.y)* 2f, direction.z * 5f), ForceMode.Impulse);

        //transform.GetComponent<Rigidbody>().velocity = (- direction) * 2f;

        transform.GetComponent<Rigidbody>().AddForce(direction * 4f, ForceMode.Impulse);

        initialPosition = currentPosition;
    }

    public void OnInputDown(InputEventData eventData)
    {
        

    }

    private Vector3 GetThrowObjectDirection(Vector3 initialPosition, Vector3 currentPosition)
    {
        Vector3 direction = new Vector3();
        float directionX = 0f;
        float directionZ = 0f;

        print("Initial position: " + initialPosition);
        print("Current position: " + currentPosition);

        // i.e. -5
        if (initialPosition.x < 0)
        {
            if (currentPosition.x < 0)
            {
                // i.e. -5
                if (currentPosition.x == initialPosition.x)
                {
                    directionX = 0f;
                }
                // i.e. -8
                else if (currentPosition.x < initialPosition.x)
                {
                    // i.e. -3
                    directionX = currentPosition.x + Mathf.Abs(initialPosition.x);
                }
                // i.e. -2
                else
                {
                    // i.e. 3
                    directionX = Mathf.Abs(currentPosition.x) + initialPosition.x;
                }
            }
            // i.e. 2
            else
                // i.e. 7
                directionX = Mathf.Abs(initialPosition.x) + currentPosition.x;
        }
        // i.e. 5
        else if (initialPosition.x > 0)
        {
            if (currentPosition.x == initialPosition.x)
                directionX = 0f;
            // 7
            if (currentPosition.x > initialPosition.x)
                // 2
                directionX = currentPosition.x - initialPosition.x;
            // 2 or -2
            else
                // -3 or -7
                directionX = currentPosition.x - initialPosition.x;
        }
        // 0
        else
        {
            directionX = initialPosition.x + currentPosition.x;
        }

        // i.e. -5
        if (initialPosition.z < 0)
        {
            if (currentPosition.z < 0)
            {
                // i.e. -5
                if (currentPosition.z == initialPosition.z)
                {
                    directionZ = 0f;
                }
                // i.e. -8
                else if (currentPosition.z < initialPosition.z)
                {
                    // i.e. -3
                    directionZ = currentPosition.z + Mathf.Abs(initialPosition.z);
                }
                // i.e. -2
                else
                {
                    // i.e. 3
                    directionZ = Mathf.Abs(currentPosition.z) + initialPosition.z;
                }
            }
            // i.e. 2
            else
                // i.e. 7
                directionZ = Mathf.Abs(initialPosition.z) + currentPosition.z;
        }
        // i.e. 5
        else if (initialPosition.z > 0)
        {
            if (currentPosition.z == initialPosition.z)
                directionZ = 0f;
            // 7
            if (currentPosition.z > initialPosition.z)
                // 2
                directionZ = currentPosition.z - initialPosition.z;
            // 2 or -2
            else
                // -3 or -7
                directionZ = currentPosition.z - initialPosition.z;
        }
        // 0
        else
        {
            directionZ = initialPosition.z + currentPosition.z;
        }

        direction.x = directionX;
        direction.z = directionZ;
        direction.y = Mathf.Abs(currentPosition.y - initialPosition.y);

        print("Direction: " + direction);

        return direction;
    }

    private Vector3 GetThrowObjectDirection2(Vector3 initialPosition, Vector3 currentPosition)
    {
        Vector3 direction = new Vector3();
        float directionX = 0f;
        float directionZ = 0f;

        print("Initial position: " + initialPosition);
        print("Current position: " + currentPosition);

        if (currentPosition.x < initialPosition.x)
        {
            if (currentPosition.x > 0)
                directionX = -currentPosition.x;
            if (currentPosition.x < 0)
                directionX = currentPosition.x;
            if (currentPosition.x == 0)
                directionX = currentPosition.x;
        }
        //if (currentPosition.x > initialPosition.x)
        //{
        //    if (currentPosition.x > 0)
        //}

        direction.x = directionX;
        direction.z = directionZ;
        direction.y = Mathf.Abs(currentPosition.y);

        print("Direction: " + direction);

        return direction;
    }
}
