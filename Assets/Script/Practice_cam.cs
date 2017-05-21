using System.Collections;
using UnityEngine;

public class Practice_cam : MonoBehaviour
{
    public Transform Target_Player;
    private Transform Cam_tr;
    private Camera Cam;


    void Start ()
    {
        Cam_tr = this.transform;
        Cam = Camera.main;
	}
	
	void Update ()
    {
        	
	}
}
