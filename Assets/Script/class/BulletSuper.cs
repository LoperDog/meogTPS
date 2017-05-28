using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSuper : MonoBehaviour {

    // 총알을 발사하기 위한 준비
    protected float BulletSpeed;
    protected Transform Bullet_tr;
    protected int PlayerCode;

    protected NetworkView m_view;

    public GameMgr Mgr;

    public virtual void FireBullet(Vector3 position, Quaternion rotation, float FireSpeed)
    {
        Bullet_tr.position = position;
        Bullet_tr.rotation = rotation;
        BulletSpeed = FireSpeed;

    }

    // 충돌처리
    protected virtual void OnTriggerEnter(Collider col)
    {

    }
    // 현제는 두개다 만들어 둔다.
    protected virtual void OnCollisionEnter(Collision col)
    {

    }

    // 생성 당시에 플레이어 코드를 
    protected void SetCode(int Code) { PlayerCode = Code; }
    protected void SetGameMgr( GameMgr gamemgr ) { Mgr = gamemgr; }
	void Start () {
		
	}
	
	void Update () {
		
	}
}
