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

    public float x = 0.0f;
    public float y = 0.0f;


    void Awake()
    {
        tr = GetComponent<Transform>();

        Vector3 angle = tr.eulerAngles;
        x = angle.x;
        y = angle.y;
    }

    void LateUpdate()
    {
        if (Player)
        {
            // 길이 제기
            Dist -= .5f * Input.mouseScrollDelta.y;
            Dist = Dist < 0.5f ? 1.0f : Dist;
            Dist = Dist >= 10.0f ? 10.0f : Dist;

            x += Input.GetAxis("Mouse X") + mouse_y_speed;
            y += Input.GetAxis("Mouse Y") + mouse_y_speed;

            y = ClamAngle(y);

            Quaternion rotation = Quaternion.Euler(y, x, 0);
            Vector3 position = rotation * new Vector3(0.0f, 0.0f, -Dist) + Player.position + new Vector3(0.0f, 0.0f, 0.0f);

            tr.rotation = rotation;
            tr.position = position; 
        }
        /*
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
        }*/
    }

    public float ClamAngle(float angle)
    {
        angle += angle < -360 ? 360 : 0.0f;
        angle -= angle > 360 ? 360 : 0.0f;

        return Mathf.Clamp(angle, Min_y, Max_y);
    }
    public void SetPlayer(Transform Pl)
    {
        Player = Pl;
    }
    /*
    public float ShootTheFuckingRay()
    {
        Vector3 FuckingRayPosition;

        return FuckingRayPosition;
    }*/
}