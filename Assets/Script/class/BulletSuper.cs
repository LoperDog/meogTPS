using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class BulletSuper : MonoBehaviour {
    // 생존 시간
    public float m_CurrentLifeTime = 0.0f;
    public float m_MaxLifeTime = 10.0f;

    // 총알을 발사하기 위한 준비
    protected float BulletSpeed;
    protected Transform Bullet_tr;
    protected int PlayerCode;

    protected bool IsLift;

    public Transform Effect;

    public GameMgr Mgr;

    public virtual void FireBullet(Vector3 position, Quaternion rotation, float FireSpeed,int code)
    {
        SetBullet(position, rotation);

        Bullet_tr = transform;

        BulletSpeed = FireSpeed;
        m_CurrentLifeTime = 0.0f;
        PlayerCode = code;
        //transform.GetComponent<Rigidbody>().AddForce(transform.forward * 2000.0f);
        IsLift = true;
    }
    /*
    // 충돌처리
    protected virtual void OnTriggerEnter(Collider col)
    {
        //Debug.Log("In Bullet Trigging Sumthing : " + PlayerCode);
        // 각도 계산 필요.
        Transform effect = Instantiate(Effect, transform.position, Quaternion.identity);
        //Destroy(effect, 0.3f);
        IsLift = false;
        if(col.tag == "PLAYER" && PlayerCode == Mgr.GetPlayerCode())
        {
            //Debug.Log("PlayerGetYa!");
            SetBulletEnalbed();
        }

    }*/
    // 현제는 두개다 만들어 둔다.
    protected virtual void OnCollisionEnter(Collision col)
    {
        // 각도 계산 필요.
        Vector3 qu = transform.position - col.transform.position;
        Transform effect = Instantiate(Effect, transform.position,Quaternion.LookRotation(qu));

        IsLift = false;
        if (col.transform.tag == "PLAYER" && PlayerCode == Mgr.GetPlayerCode())
        {
        }
        SetBulletEnalbed();
    }

    // 생성 당시에 플레이어 코드를 
    protected void SetCode(int Code) { PlayerCode = Code; }
    protected void SetGameMgr( GameMgr gamemgr ) { Mgr = gamemgr; }

    protected void SetBullet(Vector3 position, Quaternion rotation)
    {
        transform.position = position;
        transform.rotation = rotation;
        //Mgr = GameObject.FindGameObjectWithTag("GAMEMGR").GetComponent<GameMgr>() ;
    }
    // 총알을 초기화 한다.
    protected void SetBulletEnalbed()
    {
        // 시간초기화 및 자신의 비활성화
        m_CurrentLifeTime = 0.0f;
        gameObject.SetActive(false);
    }
	
	void Update () {
        if (IsLift)
        {
            Debug.DrawLine(transform.position,transform.position + transform.forward * 10f, Color.magenta);
            // 총알이 살아 있는 동안 할행동
            m_CurrentLifeTime += Time.deltaTime;
            // 만약 총알이 존재할 시간을 지났다면
            if(m_CurrentLifeTime > m_MaxLifeTime)
            {
                // 비활성화
                Debug.Log("총알 비 활성화");
                SetBulletEnalbed();
            }
        }
	}
    void FixedUpdate()
    {
        if (IsLift)
        {
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * 10f);
        }
    }

}
