using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class CameraRotation : MonoBehaviour
{
    public Transform CameraAxisTransform;


    public float MinAngle;
    public float MaxAngle;


    public float RotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      transform.localEulerAngles = new Vector3(0,transform.localEulerAngles.y + Time.deltaTime * RotationSpeed * UnityEngine.Input.GetAxis("Mouse X"), 0);

        var newAngleX = CameraAxisTransform.localEulerAngles.x - Time.deltaTime * RotationSpeed * UnityEngine.Input.GetAxis("Mouse Y");
        if (newAngleX > 180)
            newAngleX -= 360;

        newAngleX = Mathf.Clamp(newAngleX, MinAngle, MaxAngle);


        CameraAxisTransform.localEulerAngles = new Vector3(newAngleX, 0, 0);
    }
}
