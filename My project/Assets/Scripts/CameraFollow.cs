using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
public GameObject Target;

    private Vector3 _offset;

    // Start is called before the first frame update
    void Start()
    {
        _offset = transform.position + objectToFollow.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Target.transform.position + _offset;
    }
}
