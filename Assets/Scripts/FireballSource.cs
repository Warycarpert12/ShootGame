using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballSource : MonoBehaviour
{


    public Transform targetPoint;
    public Camera cameraLink;

    void Update()
    {
        var ray = cameraLink.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            targetPoint.position = hit.point;
        }

        transform.LookAt(targetPoint.position);
    }
}
