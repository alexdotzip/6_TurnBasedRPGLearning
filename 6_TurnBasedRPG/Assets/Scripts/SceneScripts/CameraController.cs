using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CameraController : MonoBehaviour
{

    public Transform target;

    public Tilemap theMap;




    // Start is called before the first frame update
    void Start()
    {
        target = PlayerController.instance.transform;
   
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);

        
    }
}
