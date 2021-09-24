using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    [SerializeField] Transform player;

    [SerializeField] GameObject playerObject;
    [SerializeField] float speed = 0f;
    private Vector3 camPos = new Vector3(0f, 0f, -10f);

    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        MoveCamara();
    }

    void MoveCamara()
    {
        transform.LookAt(player);
        /*
        float newX = playerObject.transform.position.x;
        float newY = playerObject.transform.position.y;
        float newZ = transform.position.z;
        transform.position = new Vector3(newX, newY, newZ);
        */
    }
}
