using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutinClass : MonoBehaviour
{


    CharacterSuper thisCharaterScript;

    // 코루틴으로 사용할 컴포넌트에 스크립트를 설정한다.
    public virtual void SetCharacterScript(CharacterSuper CharacterClass)
    {
        thisCharaterScript = CharacterClass;
    }
    public virtual void StartAttackSetting()
    {
        StartCoroutine(SetAttackState());
    }

    public virtual void StartReLoad()
    {
        StartCoroutine(SetReLoad());
    }
    public virtual void StartRolling()//구르기
    {
        StartCoroutine(SetRolling());
    }
    public virtual void StartBuffSetting(float time, CharacterSuper.ItemCode code, float value)
    {
        StartCoroutine(EndBuffItem(time, code, value));
    }


    // 시간초 후에 캐릭터를 확인한다.
    public virtual IEnumerator SetAttackState()
    {
        yield return new WaitForSeconds(thisCharaterScript.m_CurrentAtrack);

        thisCharaterScript.IsAttack = false;
        thisCharaterScript.AttackIsLeft = !thisCharaterScript.AttackIsLeft;
        // 두부 캐릭터만 쓰는 부분. 추후 삭제
        if (thisCharaterScript.IsFirstAttack)
        {
            thisCharaterScript.Attack();
            thisCharaterScript.IsFirstAttack = false;
        }
        else
        {
            thisCharaterScript.IsFirstAttack = true;
        }
    }
    // 리로딩
    public virtual IEnumerator SetReLoad()
    {
        yield return new WaitForSeconds(thisCharaterScript.m_TimeReload);

        thisCharaterScript.SetBullet(thisCharaterScript.m_Max_Bullet);
        thisCharaterScript.IsReLoad = false;
    }
    public virtual IEnumerator SetRolling()//구르기
    {
        yield return new WaitForSeconds(thisCharaterScript.m_Time_Rolling);
        thisCharaterScript.Is_Rolling = false;
    }
    // 아직은 작업 중.
    public virtual IEnumerator SetWhileBuff(float time)
    {
        yield return new WaitForSeconds(time);
    }

    // 추후 공격력 버프나 뭔가를 만들때 쓰자구.
    public virtual IEnumerator EndBuffItem(float time, CharacterSuper.ItemCode Code, float value)
    {
        yield return new WaitForSeconds(time);
        switch (Code)
        {
            case CharacterSuper.ItemCode.Buff_Attack:

                break;
            case CharacterSuper.ItemCode.Buff_Speed:

                break;
            case CharacterSuper.ItemCode.Buff_DotHill:

                break;
            case CharacterSuper.ItemCode.Nuff_Attack:

                break;
            case CharacterSuper.ItemCode.Nuff_Speed:

                break;
            case CharacterSuper.ItemCode.Nuff_DotDemage:

                break;
            default:
                break;
        }
    }
}