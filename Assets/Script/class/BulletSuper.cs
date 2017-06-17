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

    public GameMgr Mgr;

    public virtual void FireBullet(Vector3 position, Quaternion rotation, float FireSpeed,int code)
    {
        // 임시코드
        Debug.Log("시작은 되냐?");
        SetBullet(position, rotation);

        Bullet_tr = transform;

        BulletSpeed = FireSpeed;
        m_CurrentLifeTime = 0.0f;
        PlayerCode = code;
        transform.GetComponent<Rigidbody>().AddForce(transform.forward * 2000.0f);
        IsLift = true;
    }

    // 충돌처리
    protected virtual void OnTriggerEnter(Collider col)
    {
        Debug.Log("In Bullet Trigging Sumthing : " + PlayerCode);
        IsLift = false;
        if(col.tag == "PLAYER" && PlayerCode == Mgr.GetPlayerCode())
        {
            Debug.Log("PlayerGetYa!");
            SetBulletEnalbed();
        }

    }
    // 현제는 두개다 만들어 둔다.
    protected virtual void OnCollisionEnter(Collision col)
    {
        Debug.Log("In Bullet Colling Sumthing : " + PlayerCode);
        IsLift = false;
        if (col.transform.tag == "PLAYER" && PlayerCode == Mgr.GetPlayerCode())
        {
            Debug.Log("PlayerGetYa!");
            SetBulletEnalbed();
        }
    }

    // 생성 당시에 플레이어 코드를 
    protected void SetCode(int Code) { PlayerCode = Code; }
    protected void SetGameMgr( GameMgr gamemgr ) { Mgr = gamemgr; }

    protected void SetBullet(Vector3 position, Quaternion rotation)
    {
        transform.position = position;
        transform.rotation = rotation;
        Mgr = GameObject.FindGameObjectWithTag("GAMEMGR").GetComponent<GameMgr>() ;
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
            // 총알이 살아 있는 동안 할행동
            m_CurrentLifeTime += Time.deltaTime;
            // 만약 총알이 존재할 시간을 지났다면
            if(m_CurrentLifeTime > m_MaxLifeTime)
            {
                // 비활성화
                SetBulletEnalbed();
            }
        }
	}
    void FixedUpdate()
    {
        Debug.Log("실행자체가 안되냐" + IsLift);
        if (IsLift)
        {
            // 총알이 살아 있는 동안 할행동
            transform.Translate(transform.forward * Time.deltaTime);
            Debug.Log("실행은 되는가??");
        }
    }

}
