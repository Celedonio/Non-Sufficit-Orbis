using UnityEngine;
using System.Collections;

public class Sol : MonoBehaviour
{
    public GameObject target = null;
    public bool orbitY = false;

    void Start()
    {

    }

    void Update()
    {
        if (orbitY)
        {
                transform.RotateAround(target.transform.position, Vector3.up, Time.deltaTime * 15);
        }
    }
}
