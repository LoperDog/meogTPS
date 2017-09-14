using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigClass {
    #region 게임전체에 쓰일 부분
    public enum GameState
    {
        NoSession,
        Matching,
        InRoom,
        InGame,
        NotStart,
    };

    #endregion
    public Dictionary<string, float> ManduStatus = new Dictionary<string, float>();
    public Dictionary<string, float> DubuStatus = new Dictionary<string, float>();
    public Dictionary<string, Dictionary<string,float>> StatusConfigs = new Dictionary<string, Dictionary<string, float>>();
    public Dictionary<string, Vector3> ManduPosition = new Dictionary<string, Vector3>();
    public Dictionary<string, Vector3> DubuPosition = new Dictionary<string, Vector3>();
    public Dictionary<string, Dictionary<string, Vector3>> PositionConfig = new Dictionary<string, Dictionary<string, Vector3>>();

    public string ManduString = "Mandu";
    public string DubuString = "Dubu";
    
    public ConfigClass()
    {
        #region 만두콘피그
        ManduStatus.Add("HP", 150f);

        ManduStatus.Add("MoveSpeed", 2.0f);
        ManduStatus.Add("RunSpeed" , 6.8f);
        ManduStatus.Add("JumpForce" , 4000f);

        ManduStatus.Add("Cartridge" , 10f);
        ManduStatus.Add("ReLoadTime" , 2.0f);

        ManduStatus.Add("Attack" , 50f);
        ManduStatus.Add("AtttackSpeed" , 2.0f);

        ManduStatus.Add("StrongAttack" , 100f);
        ManduStatus.Add("StrongAttackSpeed" , 2.0f);

        ManduStatus.Add("SpecialAttack" , 0.0f);
        ManduStatus.Add("SpecialAttackSpeed" , 0.0f);

        ManduPosition.Add("FirePosition", new Vector3(0.0f, 1.15f, 0.8f));
        #endregion

        #region 두부콘피그
        // 채력
        DubuStatus["HP"] = 100f;
        // 이동속도
        DubuStatus["MoveSpeed"] = 2.8f;
        DubuStatus["RunSpeed"] = 7.5f;
        DubuStatus["JumpForce"] = 5000f;
        // 장탄수 및 리로드 시간
        DubuStatus["Cartridge"] = 50f;
        DubuStatus["ReLoadTime"] = 1.7f;
        // 기본공격
        DubuStatus["Attack"] = 15f;
        DubuStatus["AtttackSpeed"] = 0.25f;
        // 강공격
        DubuStatus["StrongAttack"] = 30f;
        DubuStatus["StrongAttackSpeed"] = 5.0f;
        // 특수기
        DubuStatus["SpecialAttack"] = 100.0f;
        DubuStatus["SpecialAttackSpeed"] =  25.0f;

        // 필요 포지션
        DubuPosition["FirePosition"] = new Vector3(0.0f, 1.15f, 0.8f);
        #endregion

        // 콘피그 적용. 
        StatusConfigs.Add(ManduString, ManduStatus);
        StatusConfigs.Add(DubuString, DubuStatus);
        PositionConfig.Add(ManduString, ManduPosition);
        PositionConfig.Add(DubuString, DubuPosition);
    }
}
