﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DubuCharacter : CharacterSuper
{
    // 이팩트 시작 위치나 등등을 잡아줘야 한다.
    public bool AttackIsLeft = false;
    
    public DubuAnimation  CharAnim;
    override public void Attack()
    { 
        // 공격중이 아닌데 공격 이 시작된다면 - 공격 가능
        if (!IsAttack && !IsReLoad && m_Current_Bullet > 0)
        {
            //공격 시작 코드
            m_Current_Bullet--;
            IsAttack = true;
            // 왼쪽공격이라면
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
            AttackIsLeft = !AttackIsLeft;
            //기본 사속을 조금씩 줄인다.
            if((m_CurrentAttack - 0.005f) >= 0.0f)
            {
                m_CurrentAttack -= 0.005f;
            }
        }
        // 공격이 시작될수 있는데 총알이 없다면 - 공격 불가 상태
        else if (!IsAttack && !IsReLoad && m_Current_Bullet == 0)
        {
            ReLoad();
        }
        else
        {
            //m_CurrentAttack = 0.0f;
        }
    }
    // 마우스 오른쪽 버튼이 눌리는 순간 실행되는 함수.
    // 강공격을 시작한다.
    public override void StrongAttack()
    {
        if (!IsStrongAttack && GetIsGroud())//강공격이 아니고 땅에 있을 때
        {
            coroutine.StartStrongAttckSetting();
        }
    }
    public void StrongAttackReady()
    {
        CharAnim.SetStrongAttackReady();
    }
    // 강공격 대미지가 들어가는 부분.
    // 이팩트 생성, 애니매이션 재생. 
    public void StrongAttackDash()
    {
        CharAnim.SetStrongAttackDash();
        Player_rb.AddForce(Player_tr.forward * 20000f);
    }
    // 강공격이 끝나는 부분.
    public void StrongAttackEnd()
    {
        CharAnim.SetStrongAttackEnd();
    }
    //특수기 시작
    public override void SpecialAttack()
    {
        if (!IsSpecialAttack && GetIsGroud())
        {
            coroutine.StartSpecialAttackSetting();
        }
    }
    public void SpecialAttackReady()
    {
        CharAnim.SetSpecialAttackReady();
    }
    public void SpecialAttackDash()
    {
        CharAnim.SetSpecialAttackDash();
    }
    public void SpecialAttackEnd()
    {
        CharAnim.SetSpecialAttackEnd();
    }
    public override void UpAttack()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        CurrentAttack = config.StatusConfigs["Dubu"]["AtttackSpeed"];
    }
    public override void ReLoad()
    {
        base.ReLoad();
        if(config == null)
        {
            config = new ConfigClass();
        }
        CurrentAttack = config.StatusConfigs["Dubu"]["AtttackSpeed"];
    }
    // 애니매이터 세팅을 바꿔준다. 여기에 온다면 분명 두부 애니매이션 일테니까
    public override void SetAnimator(AnimationSuper anim)
    {
        base.SetAnimator(anim);
        CharAnim = (DubuAnimation)anim;
    }
}
