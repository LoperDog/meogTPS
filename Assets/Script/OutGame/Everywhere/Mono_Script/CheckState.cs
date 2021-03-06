﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ConstValueInfo;
using UnityEngine.SceneManagement;


public class CheckState : MonoBehaviour {

    static ProtocolSceneName mCurrentSceneState;
    static State mCurrentState;
    static GameObject mChannelMasterPanel;
    static GameObject mFront;
    //static GameObject mSelectLoginPanel;     // FrontScene
    //static GameObject mSelectPanel;          // FrontScene
    static bool mIsSceneChangeStart;    // Scene 변경 예정
    static bool mIsSceneChanged;        // Scene 변경 완료
    static bool mIsStateChanged;
    // Use this for initialization
    void Awake () {
        DontDestroyOnLoad(this.gameObject);
        mCurrentSceneState = ProtocolSceneName.FrontScene;
        mIsSceneChangeStart = false;
        mIsSceneChanged = false;
        mIsStateChanged = false;
        ChangeState(State.ClientFrontMenu);
    }

    public static void ChangeSceneState(ProtocolSceneName state)
    {
        mCurrentSceneState = state;
        mIsSceneChangeStart = true;
        //ActiveObject(state);
    }

    public static void ChangeState(State state)
    {
        mCurrentState = state;
        mIsStateChanged = true;
        //ActiveObject(state);
    }

    public static State GetCurState()
    {
        return mCurrentState;
    }

    public static ProtocolSceneName GetCurScene()
    {
        return mCurrentSceneState;
    }

    void Update()
    {
        if(mIsSceneChanged) // 씬이 바뀌고 난 후 처음 해주는 일 (한번만 함)
        {
            switch (mCurrentSceneState)
            {
                case ProtocolSceneName.FrontScene:
                    ChangeState(State.ClientFrontMenu);
                    //mLoginStatePanels = GameObject.FindGameObjectsWithTag("LoginPanel");
                    //mLoginStateScripts = GameObject.FindGameObjectsWithTag("LoginScript");
                    break;
                case ProtocolSceneName.ChannelScene:
                    mChannelMasterPanel = GameObject.FindGameObjectWithTag("TagChannelMaster");
                    ChangeState(State.ClientChannelMenu);// 채널 메뉴
                    break;
                case ProtocolSceneName.RoomScene:
                    ChangeState(State.ClientNotReady);
                    //mRoomStatePanels = GameObject.FindGameObjectsWithTag("RoomPanel");
                    //mRoomStateScripts = GameObject.FindGameObjectsWithTag("RoomScript");
                    break;
                default:
                    break;
            }
            mIsSceneChanged = false;
        }

        if(mIsStateChanged) // 상태가 바뀌면 처음 해주는 일 (한번만 함)
        {
            switch (mCurrentState)
            {
                case State.ClientFrontMenu: // Scene전환시 호출 기본
                    FrontInit(true, false, false);
                    break;
                case State.ClientLogin:
                    FrontInit(false, false, true);
                    break;
                case State.ClientGuest:
                    FrontInit(false, true, false);
                    break;
                case State.ClientRequestMatching:
                    break;
                case State.ClientMatching:
                    ChannelInit(true, false);
                    break;
                case State.ClientChannelMenu:
                    ChannelInit(false, false);
                    break;
                case State.ClientMakeRoom:
                    ChannelInit(false, true);
                    break;
                case State.ClientReady:
                    break;
                case State.ClientNotReady:
                    Chatting ChatScript;
                    ChatScript = GameObject.FindGameObjectWithTag("ChatPanel").GetComponent<Chatting>();
                    if (null != ChatScript)
                    {
                        ChatScript.AddDialogue(ConstValue.NoticeNotReadyState);
                    }                    
                    break;
                default:
                    break;
            }
            mIsStateChanged = false;
        }

        if(mIsSceneChangeStart) // 씬이 바뀌는 작업
        {
            SceneManager.LoadScene(ConstValue.ProtocolSceneName[(int)mCurrentSceneState]);
            mIsSceneChangeStart = false;
            mIsSceneChanged = true;
        }
    }

    void FrontInit(bool select, bool guest, bool login)
    {
        mFront = GameObject.FindGameObjectWithTag("TagFront");
        GameObject selectLoginPanel = mFront.GetComponentInChildren<Transform>().FindChild("SelectLoginPanel").gameObject;
        GameObject guestPanel = mFront.GetComponentInChildren<Transform>().FindChild("GuestPanel").gameObject;
        GameObject loginPanel = mFront.GetComponentInChildren<Transform>().FindChild("LoginPanel").gameObject;

        selectLoginPanel.SetActive(select);
        guestPanel.SetActive(guest);
        loginPanel.SetActive(login);
    }

    void ChannelInit(bool matching, bool makeRoom)
    {
        GameObject matchingPanel = mChannelMasterPanel.GetComponentInChildren<Transform>().FindChild("MatchingPanel").gameObject;
        matchingPanel.SetActive(matching);

        GameObject makeRoomPanel = mChannelMasterPanel.GetComponentInChildren<Transform>().FindChild("MakeRoomPanel").gameObject;
        makeRoomPanel.SetActive(makeRoom);
    }

}
