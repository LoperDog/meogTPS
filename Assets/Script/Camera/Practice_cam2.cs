using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice_cam2 : MonoBehaviour
{
    private Transform Cam_Tr;
    public Transform Target_tr;

    public float X = 0.0f;
    public float Y = 1.0f;
    public float Z = 3.0f;

    Vector3 Gap;

	void Start ()
    {
        Cam_Tr = GetComponent<Transform>();
        Target_tr = Target_tr.GetComponent<Transform>();
    }

    void LateUpdate()
    {
        Cam_Tr.eulerAngles= new Vector3(Target_tr.rotation.eulerAngles.x, Target_tr.rotation.eulerAngles.y, Target_tr.rotation.eulerAngles.z);
    }
}