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

    public bool IsAttack = true;
    public bool IsReLoad = false;
    protected bool Is_Ground = true;
    protected bool Is_Jump;
    protected bool IsRun = false;

    protected int m_Current_Bullet = 0;
    protected int m_Max_Bullet = 0;

    //이동
    protected float m_Move_H = 0.0f;
    protected float m_Move_V = 0.0f;
    protected float m_Current_Speed;
    protected float m_Move_Speed = 1.0f;
    protected float m_Run_Speed = 2.0f;

    //회전
    protected float Min_X = -360.0f;
    protected float Max_X = 360.0f;
    protected float Sens_X = 100.0f;
    protected float Rotation_X = 0.0f;

    //점프
    protected float m_Jump_Force = 250.0f;

    protected Transform Player_tr;
    protected GameObject Player_Object;
    // 조금 알아보고 쓰자.
    protected GameObject BaseBullet;
    protected Dictionary<int, Queue<GameObject>> BulletPool = new Dictionary<int, Queue<GameObject>>();

    protected CoroutinClass coroutine;
    protected GameObject FirePoint;

    protected Rigidbody Player_rb;
    protected Transform Camera_tr;
    
    public virtual void CharacterUpdate()
    {
        //공격중이라면
        if (IsAttack)
        {
            //coroutine.StartAttackSetting();
            IsAttack = false;
        }
        Check_Ground();
        Move();
        Run();
        Jump();
    }
    // 생성자.
    public CharacterSuper()
    {
        m_CurrentAtrack = 1.0f;
        m_TimeAttack = 0.5f;
        m_CurrentReload = 0.0f;
        m_TimeReload = 1.0f;
        PlayerCode = 0;
    }
    #region 캐릭터 기능 정의
    public virtual void Attack()
    {
        // 공격중이 아닌데 공격 이 시작된다면 - 공격 가능
        if(m_CurrentAtrack > m_TimeAttack && !IsAttack && !IsReLoad && m_Current_Bullet >0)
        {
            //공격 시작 코드
            m_Current_Bullet--;
            IsAttack = true;
            ShotBullet();
        }
        // 공격이 시작될수 있는데 총알이 없다면 - 공격 불가 상태
        else if (m_CurrentAtrack > m_TimeAttack && !IsAttack && !IsReLoad && m_Current_Bullet == 0)
        {
            // 리로드 시작.
            IsReLoad = true;
        }
        // 
        else
        {
            m_CurrentAtrack = 0.0f;
        }
    }

    public virtual void Move()
    {
        Vector3 forward = Player_tr.TransformDirection(Vector3.forward);
        forward = forward.normalized;

        Vector3 right = new Vector3(forward.z, 0, -forward.x);
        Vector3 moveDirection = (m_Move_H * right) + (m_Move_V * forward);
        Player_tr.position = Player_tr.position + moveDirection * m_Current_Speed * Time.deltaTime;
        Rotation_X += Input.GetAxis("Mouse X") * Sens_X * Time.deltaTime;
        Player_tr.localEulerAngles = new Vector3(0, Rotation_X, 0);
    }
    public virtual void Run()
    {
        if (Input.GetKey(KeyCode.LeftShift) && (m_Move_V > 0.1) && Is_Ground)
        {
            m_Current_Speed = m_Run_Speed;
        }
        else
        {
            m_Current_Speed = m_Move_Speed;
        }
    }
    public virtual void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Is_Ground)
        {
            Is_Jump = true;
        }

        if (Is_Jump)
        {
            Player_rb.AddForce(0, m_Jump_Force, 0);
            Is_Jump = false;
        }

    }
    public virtual void Check_Ground()
    {
        RaycastHit hit;
        Debug.DrawRay(Player_tr.position, Vector3.down * 0.01f, Color.red);
        if (Physics.Raycast(Player_tr.position, Vector3.down, out hit, 0.01f))
        {
            if (hit.collider.tag == "GROUND")
            {
                Is_Ground = true;
                return;
            }
        }
        Is_Ground = false;
    }
    public virtual void ReLoad()
    {
        Debug.Log("상속전 재장전");
    }
    // 총알을 발사한다.
    public virtual void ShotBullet()
    {
        Debug.Log("상속전 공격 -> 오브젝트를 생성시킨다.");

    }
    public virtual void ReuseBullet(GameObject Object,Vector3 position, Quaternion rotation)
    {
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
                FirePoint.transform.rotation,10.0f,PlayerCode);

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
                BulletPool[poolkey].Enqueue(newBullet);
            }
        }
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
    public virtual void SetRun(bool KeyShift){ IsRun = KeyShift;}
    public virtual void SetMoveH(float KeyH) { m_Move_H = KeyH; }
    public virtual void SetMoveV(float KeyV) { m_Move_V = KeyV; }
    
    #endregion
    #region 캐릭터 상태값 가져오기
    public virtual bool GetAttackorReload() { return IsAttack || IsReLoad; }
    public virtual bool GetIsAttack() { return IsAttack; }
    public virtual bool GetIsReload() { return IsReLoad; }
    public virtual float GetMoveH() { return m_Move_H; }
    public virtual float GetMoveV() { return m_Move_V; }
    public virtual bool GetIsRun() { return IsRun; }
    public virtual bool GetIsJump() { return Is_Jump; }
    public virtual bool GetIsGroud() { return Is_Ground; }
    // 0 이라면 트루
    public virtual bool GetEmptyBullet() { return m_Current_Bullet == 0; }
    #endregion
    
    // 소멸
    ~CharacterSuper()
    {

    }
}
