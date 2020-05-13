using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject Small_Plane02;
    private Vector3 offset = new Vector3(22, 3, 9);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Small_Plane02.transform.position + offset;
    }
}
