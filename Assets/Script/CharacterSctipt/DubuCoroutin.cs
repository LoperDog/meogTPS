using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DubuCoroutin : CoroutinClass
{
    public DubuCharacter DubuChar;
    public override void SetCharacterScript(CharacterSuper CharacterClass)
    {
        base.SetCharacterScript(CharacterClass);
        DubuChar = (DubuCharacter)CharacterClass;
    }

    public override void StartStrongAttckSetting()
    {
        if(config == null)
        {
            config = new ConfigClass();
        }
        thisMgr.StrongAttackCoolTime = config.StatusConfigs["Dubu"]["StrongAttackSpeed"];
        base.StartStrongAttckSetting();
    }
    public override void StartSpecialAttackSetting()
    {

        if (config == null)
        {
            config = new ConfigClass();
        }
        thisMgr.SpecialAttackCoolTime = config.StatusConfigs["Dubu"]["SpecialAttackSpeed"];
        base.StartSpecialAttackSetting();
    }
    //강공격
    public override IEnumerator SetStrongAttack()
    {
        if(config == null)
        {
            config = new ConfigClass();
        }
        thisCharacterScript.CanControll = false;
        StartCoroutine(SetStrongAttackReady());
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["StrongAttackSpeed"]);
        thisCharacterScript.IsStrongAttack = false;
    }
    public IEnumerator SetStrongAttackReady()
    {
        if(config == null)
        {
            config = new ConfigClass();
        }
        DubuChar.StrongAttackReady();
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["StongAttackReady"]);
        StartCoroutine(SetStrongAttackDash());
    }
    public IEnumerator SetStrongAttackDash()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        DubuChar.StrongAttackDash();
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["StongAttackTime"]);
        StartCoroutine(SetStrongAttackEnd());
    }
    public IEnumerator SetStrongAttackEnd()
    {
        if(config == null)
        {
            config = new ConfigClass();
        }
        DubuChar.StrongAttackEnd();
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["StongAttackEnd"]);
        thisCharacterScript.CanControll = true;
    }

    //특수기
    public override IEnumerator SetSpecialAttack()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        StartCoroutine(SetSpecialSpecialAttakReady());
        thisCharacterScript.CanControll = false;
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["SpecialAttackSpeed"]);
        thisCharacterScript.IsSpecialAttack = false;
    }
    public IEnumerator SetSpecialSpecialAttakReady()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        DubuChar.SpecialAttackReady();
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["SpecialAttackReady"]);
        StartCoroutine(SetSpecialSpecialAttakDash());
    }

    public IEnumerator SetSpecialSpecialAttakDash()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        DubuChar.SpecialAttackDash();
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["SpecialAttackTime"]);
        StartCoroutine(SetSpecialAttackEnd());
    }
    public IEnumerator SetSpecialAttackEnd()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        DubuChar.SpecialAttackEnd();
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["SpecialAttackEnd"]);
        thisCharacterScript.CanControll = true;
    }
}
