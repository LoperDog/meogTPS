 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSuper : MonoBehaviour{
    
    // 버프 아이템이나 종류
    public enum ItemCode
    {
        Buff_Attack,
        Buff_Speed,
        Buff_DotHill,
        Nuff_Attack,
        Nuff_Speed,
        Nuff_DotDemage
    };

    // 공격 시작시간과 공격 
    public float m_CurrentAtrack;
    public float m_TimeAttack;
    public float m_CurrentReload;
    public float m_TimeReload;

    public int PlayerCode;

    public bool IsAttack = false;
    public bool IsReLoad = false;
    protected bool Is_Ground = true;
    protected bool Is_Jump;
    protected bool Is_Run = false;
    public bool Is_Rolling;
    public bool Is_Dead = false;

    public int m_Current_Bullet = 0;
    public int m_Max_Bullet = 0;

    //이동
    protected float m_Move_H = 0.0f;
    protected float m_Move_V = 0.0f;
    protected float m_Current_Speed = 0;
    protected float m_Move_Speed = 5.5f;
    protected float m_Run_Speed = 5.5f;

    //회전
    protected float Min_X = -360.0f;
    protected float Max_X = 360.0f;
    protected float Sens_X = 100.0f;
    protected float Rotation_X = 0.0f;

    //점프
    protected float m_Jump_Force = 250.0f;

    //구르기
    public float m_Time_Rolling;

    public Transform Player_tr;
    public Rigidbody Player_rb;
    protected GameObject Player_Object;
    // 조금 알아보고 쓰자.
    protected GameObject BaseBullet;
    protected Dictionary<int, Queue<GameObject>> BulletPool = new Dictionary<int, Queue<GameObject>>();

    protected CoroutinClass coroutine;
    protected GameObject FirePoint;

    protected Transform Camera_tr;

    // 두부에서만 쓰는 공격 이팩트 뜨는 위치.
    public bool AttackIsLeft = false;
    // 두부에서만 쓰는 것.
    public bool IsFirstAttack = true;
    // 이팩트 뜰 위치를 정한다.
    public Transform [] effectPosition;
    public Transform[] effect;

    public virtual void CharacterUpdate()
    {
        Check_Ground();
        Move();
        Run();
    }
    // 생성자.
    public void SetCharacterSuper()
    {
        m_CurrentAtrack = 1.0f;
        m_TimeAttack = 0.5f;
        m_CurrentReload = 0.0f;
        m_TimeReload = 0.7f;
        m_Time_Rolling = 5.0f;
        PlayerCode = 0;
    }
    #region 캐릭터 기능 정의
    public virtual void Attack()
    {
        // 공격중이 아닌데 공격 이 시작된다면 - 공격 가능
        if(!IsAttack && !IsReLoad && m_Current_Bullet >0)
        {
            //공격 시작 코드
            m_Current_Bullet--;
            IsAttack = true;
            // 왼쪽공격이라면 ----- 이건 나중에 수정하도록 한다.
            if (AttackIsLeft)
            {
                Transform temp = Instantiate(effect[0], effectPosition[0].position, effectPosition[0].rotation * effect[0].rotation);
                temp.GetComponent<DestroyMe1>().Target = effectPosition[0];
            }
            else
            {
                Transform temp = Instantiate(effect[1], effectPosition[1].position, effectPosition[1].rotation * effect[1].rotation);
                temp.GetComponent<DestroyMe1>().Target = effectPosition[1];
            }
            ShotBullet();
        }
        // 공격이 시작될수 있는데 총알이 없다면 - 공격 불가 상태
        else if (!IsAttack && !IsReLoad && m_Current_Bullet == 0)
        {
            // 리로드 시작.
            IsReLoad = true;
            coroutine.StartReLoad();
        }
        // 
        else
        {
            //m_CurrentAtrack = 0.0f;
        }
    }

    public virtual void Move()
    {
        Vector3 forward = Player_tr.TransformDirection(Vector3.forward);
        forward = forward.normalized;

        Vector3 right = new Vector3(forward.z, 0, -forward.x);
        Vector3 moveDirection = (m_Move_H * right) + (m_Move_V * forward);
        Player_tr.position = Player_tr.position + moveDirection * m_Current_Speed * Time.deltaTime;
    }
    public virtual void Turn()
    {
        Player_tr.rotation = Quaternion.Euler(0.0f, Camera.main.transform.rotation.eulerAngles.y, 0.0f);
    }
    public virtual void Run()
    {
        if (Is_Run && (m_Move_V > 0.1) && Is_Ground && m_Current_Speed <= m_Run_Speed)
        {
            m_Current_Speed += 20.0f * Time.deltaTime;
        }
        else if ((m_Move_H != 0.0f || m_Move_V != 0.0f) && m_Current_Speed <= m_Move_Speed)
        {
            m_Current_Speed += 20.0f * Time.deltaTime;
        }
        else if(m_Current_Speed != 0)
        {
            m_Current_Speed += (m_Current_Speed > 0) ? -20.0f * Time.deltaTime :
                                                        20.0f * Time.deltaTime;
            m_Current_Speed = (m_Current_Speed >= -0.1f && m_Current_Speed <= 0.1f) ? 0.0f : m_Current_Speed;
        }
    }
    public virtual void Jump()
    {
        if (IsReLoad) return;
        if (Is_Ground)
        {
            Player_rb.AddForce(0, m_Jump_Force, 0);
        }
    }
    public virtual void Check_Ground()
    {
        RaycastHit hit;
        //Debug.DrawRay(Player_tr.position, Vector3.down * 0.2f, Color.red);
        if (Physics.Raycast(Player_tr.position, Vector3.down, out hit, 0.2f))
        {
            if (hit.collider.tag == "GROUND")
            {
                Is_Ground = true;
                return;
            }
        }
        Is_Ground = false;
    }
    public virtual void Rolling()
    {
        if (IsReLoad) return;
        if (!Is_Rolling && !GetIsReload() && GetIsGroud())//재장전이 아니고 땅에 있을 때
        {
            Is_Rolling = true;
            coroutine.StartRolling();
            Player_rb.AddForce(Player_tr.forward * 4000);
        }
    }
    public virtual void ReLoad()
    {
        if ((!IsReLoad) && (m_Current_Bullet != m_Max_Bullet)) //재장전이 아니고 총알이 최대가 아니며 R키를 누를 때 재장전
        {
            IsReLoad = true;
            coroutine.StartReLoad();
        }
    }
    // 총알을 발사한다.
    public virtual void ShotBullet()
    {
        coroutine.StartAttackSetting();        
        ReuseBullet(BaseBullet, FirePoint.transform.position, FirePoint.transform.rotation);
    }
    public virtual void ReuseBullet(GameObject Object,Vector3 position, Quaternion rotation)
    {
        //Debug.Log("총알생성" + BaseBullet.name);
        int poolkey = Object.GetInstanceID();

        if (BulletPool.ContainsKey(poolkey))
        {
            GameObject objectToReuse = BulletPool[poolkey].Dequeue();
            BulletPool[poolkey].Enqueue(objectToReuse);

            // 활성화 시킨다.
            objectToReuse.SetActive(true);
            // 오브젝트 사용하기 위해 세팅을 하자.
            // 발사할 위치를 정하거나 하는 둥의 액션.
            objectToReuse.GetComponent<BulletSuper>().FireBullet(FirePoint.transform.position,
                FirePoint.transform.rotation,1.0f,PlayerCode);

        }
    }

    public virtual void StartReload()
    {
        Debug.Log("상속전 캐릭터 재장전 시작");
    }
    public virtual void EndReLoad()
    {
        Debug.Log("상속전 캐릭터 재장전 끝");
    }
    #endregion

    #region 캐릭터 기본 세팅
    public virtual void SetFirePoint(GameObject point) { FirePoint = point; }
    public virtual void SetreLoadTime(float time) { m_TimeReload = time; }
    public virtual void SetBullet(int bulletMax)
    {
        m_Max_Bullet = bulletMax;
        m_Current_Bullet = bulletMax;
    }
    public virtual void SetMoveSpeed(float moveSpeed) { m_Move_Speed = moveSpeed; }
    public virtual void SetRunSpeed(float run_Speed) { m_Run_Speed = run_Speed; }
    public virtual void SetJumpForce(float jump_Force) { m_Jump_Force = jump_Force; }
    public virtual void SetPlayerTr(Transform player) { Player_tr = player; }
    public virtual void SetPlayerOb(GameObject player_ob) { Player_Object = player_ob; }
    public virtual void SetAttackSpeed(float att_Speed) { m_CurrentAtrack = att_Speed; }
    public virtual void SetCoroutine(CoroutinClass co) {
        coroutine = co;
        coroutine.SetCharacterScript(this);
    }
    public virtual void SetCameraTr(Transform camera) { Camera_tr = camera; }
    public virtual void SetPlayerRb(Rigidbody rigidbody) { Player_rb = rigidbody; }
    public virtual void SetCharacterMove(float H, float V) {m_Move_H = H; m_Move_V = V;}
    public virtual void SetBulletObject(GameObject bullet) { BaseBullet = bullet; }

    public virtual void SetPlayerCode(int Code) { PlayerCode = Code; }

    public virtual void CreateBullet(int size, GameObject Object)
    {
        /*
         * 오브젝트 풀에 여러 가지 총알을 만들수 있는 여부를 둔 이유는
         * 캐릭터의 메인이 되는 총알이 아닌 것들 또한 사용하게 하기위해서이다.
         * 즉 특수기가 연속 발사이거나 하는 등의 경우를 상정해 두고 작업 하기 위함.
         */
        // 총알 인스턴스의 고유 값을 가져온다.
        //Debug.Log("총알 풀링");
        int poolkey = Object.GetInstanceID();

        // 이미 총알 풀에 그값이 있는지 없는지 검사 한다. 없어야 넣는다.
        if (!BulletPool.ContainsKey(poolkey))
        {
            // 풀에 키값을 넣고 그에 맞는 총알 큐를 만든다.
            BulletPool.Add(poolkey, new Queue<GameObject>());
            for(int i = 0; i < size; i++)
            {
                GameObject newBullet = Instantiate(Object) as GameObject;
                newBullet.SetActive(false);
                newBullet.GetComponent<BulletSuper>().Player_tr = Player_tr;
                BulletPool[poolkey].Enqueue(newBullet);
            }
        }
    }
    // 이팩트 위치 잡아주기.
    public virtual void SetEffectPosition(Transform[] ps)
    {
        effectPosition = ps;

    }
    public virtual void SetEffect(Transform[] ef)
    {
        effect = ef;
    }
    #endregion

    #region 아이템 영역
    protected virtual void SetItem(float time,ItemCode code,float val)
    {
        switch (code)
        {
            case ItemCode.Buff_Attack:
                
                break;
            case ItemCode.Buff_DotHill:
                break;
            case ItemCode.Nuff_Attack:
                break;
            case ItemCode.Nuff_Speed:
                break;
            case ItemCode.Nuff_DotDemage:

                break;
            default:
                break;
        }
        coroutine.StartBuffSetting(time, code, val);
    }
    #endregion
    #region 키세팅영역
    public virtual void SetRun(bool KeyShift){ Is_Run = KeyShift;}
    public virtual void SetMoveH(float KeyH) { m_Move_H = KeyH; }
    public virtual void SetMoveV(float KeyV) { m_Move_V = KeyV; }
    
    #endregion
    #region 캐릭터 상태값 가져오기
    public virtual bool GetAttackorReload() { return IsAttack || IsReLoad; }
    public virtual bool GetIsAttack() { return IsAttack; }
    public virtual bool GetIsReload() { return IsReLoad; }
    public virtual float GetMoveH() { return m_Move_H; }
    public virtual float GetMoveV() { return m_Move_V; }
    public virtual float GetSpeed() { return m_Current_Speed; }
    public virtual bool GetIsRun() { return Is_Run; }
    public virtual bool GetIsJump() { return Is_Jump; }
    public virtual bool GetIsGroud() { return Is_Ground; }
    public virtual bool GetIsRolling() { return Is_Rolling; }
    public virtual bool GetIsAttackLeft() { return AttackIsLeft; }
    public virtual bool GetIsDead() { return Is_Dead; }
    // 0 이라면 트루
    public virtual bool GetEmptyBullet() { return m_Current_Bullet == 0; }
    #endregion
    
    // 소멸
    ~CharacterSuper()
    {

    }
}
