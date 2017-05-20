using System.Collections;
using UnityEngine;

public class Cam : MonoBehaviour
{
    private Transform Cam_tr;
    public Transform Player_Target;

    Vector3 Cam_position;
    Vector3 Cam_Rotation;

    //position
    private float Dist = 10.0f;
    private float Height = 5.0f;

    //rotation
    private float Rotation_x = 10.0f;
    private float Rotation_y = 0.0f;
    private float Rotation_z = 0.0f;

    private float mouse_x = 0.0f;
    private float mouse_y = 0.0f;

    void Awake()
    {
        Cam_tr = GetComponent<Transform>();
    }

    void Start()
    {

    }

    void Update()
    {
        mouse_x = Input.GetAxis("Mouse X");
        mouse_y += -Input.GetAxis("Mouse Y");
    }

    void LateUpdate()
    {
        transform.LookAt(Player_Target);
    }
}