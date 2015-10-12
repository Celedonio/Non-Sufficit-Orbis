using UnityEngine;
using System.Collections;

public class Cámara_móvil : MonoBehaviour
{
    public GameObject target = null;

	void Start ()
    {
	    
	}
	
	void Update ()
    {
        if (target != null)
        {
            transform.LookAt (target.transform);
        }

    }
}
