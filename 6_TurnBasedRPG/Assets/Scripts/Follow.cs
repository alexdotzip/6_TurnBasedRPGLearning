using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    private CinemachineVirtualCamera vcam;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        vcam = GetComponent<CinemachineVirtualCamera>();
        vcam.LookAt = target;
        vcam.Follow = target;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
