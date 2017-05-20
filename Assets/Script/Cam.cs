using System.Collections;
using UnityEngine;

public class Cam : MonoBehaviour
{
    private Transform tr;
    public Transform Player;

    public float Height = 2.3f; //높이
    public float Dist = 2.8f;//거리
    private float mouse_y = 0.0f;//마우스 상하값
    public float mouse_y_speed = 100.0f;//상하 회전속도
    public float Max_y = 320.0f;//최대각
    public float Min_y = 30.0f; //최소각

    private int Cam_State = 0;

    void Awake()
    {
        tr = GetComponent<Transform>();
    }

    void LateUpdate()
    {
        mouse_y = -Input.GetAxis("Mouse Y");
        {
            if (tr.rotation.eulerAngles.x + mouse_y <= Min_y || tr.rotation.eulerAngles.x + mouse_y >= Max_y)
            {
                tr.Rotate(Vector3.right * mouse_y_speed * mouse_y * Time.deltaTime);
                tr.position += new Vector3(0 , mouse_y, 0);
            }

            else if (tr.rotation.eulerAngles.x + mouse_y >= Min_y && tr.rotation.eulerAngles.x + mouse_y <= 180)
            {
                tr.localEulerAngles = new Vector3(Min_y, 0, 0);
            }

            else
            {
                tr.localEulerAngles = new Vector3(Max_y, 0, 0);
            }
        }
    }
}