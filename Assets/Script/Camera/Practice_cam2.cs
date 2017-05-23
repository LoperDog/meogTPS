using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice_cam2 : MonoBehaviour
{
    private Transform Cam_Tr;
    public Transform Target;

    private float X = 0.4f;
    private float Y = 1.0f;
    private float Z = -2.0f;

    private float mouse_x = 0.0f;
    Vector3 Cam_position;
    Vector3 Gap;

	void Start ()
    {
        Cam_Tr = GetComponent<Transform>();
        Cam_Tr.position = new Vector3(X, Y, Z);
        Gap = Cam_Tr.position - Target.transform.position;
    }

    void LateUpdate()
    {
        mouse_x = Input.GetAxis("Mouse X");
        //Cam_Tr.position = Target.transform.position + Gap;
        transform.RotateAround(Target.transform.position+Gap, Vector3.up, mouse_x * 20 * Time.deltaTime);
    }
}