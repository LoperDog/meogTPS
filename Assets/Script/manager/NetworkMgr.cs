using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using UnityEngine;
using ConstValueInfo;
using System;

public class NetworkMgr : MonoBehaviour
{
    private string MyIP = "";
    private string OtherIP = "";

    // 플레이어 번호에 맞는 생성위치를 잡아준다.
    private Vector3[] PlayerCreatePosition = new Vector3[6];
    //접속 IP
    private const string ip = "192.168.30.64";
    //접속 Port
    private const int port = 9000;
    //NAT 기능의 사용 여부
    private bool _useNat = false;
    // 플레이어 프리팹
    public GameObject[] player = new GameObject[4];
    public GameObject MyPlayer;
    public int MyPlayerNumb = 0;

    // 플레이어의 수를 확인한다.
    // public int PlayerLimit = MyInfoClass.GetInstance().PlayerLimit;
    public int PlayerLimit = 2;
    // 게임이 시작되었는지 확인한다.
    public bool IsStartGame = false;
    
    // 시작할때 플레이어들의 번호에 맞추어 넣자.
    private void Start()
    {
        PlayerCreatePosition[0] = new Vector3(-25f, 10f, 5f);
        PlayerCreatePosition[2] = new Vector3(-25f, 10f, 0);
        PlayerCreatePosition[4] = new Vector3(-25f, 10f, -5f);
        PlayerCreatePosition[5] = new Vector3(25f, 10f, -5f);
        PlayerCreatePosition[3] = new Vector3(25f, 10f, 0);
        PlayerCreatePosition[1] = new Vector3(25f, 10f, 5f);
        
        // 싱글 플레이시에는 여기서 부터 스타트함수를 끝까지 주석한다.
        /*
        MyInfoClass.GetInstance().MyNetwork = this;

        if (Network.peerType == NetworkPeerType.Disconnected)
        {
            
            IPHostEntry host = Dns.GetHostByName(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    MyIP = ip.ToString();
                    break;
                }
            }
            MyIP = Network.player.ipAddress;
            Debug.Log(MyIP);
            // 연결 요청
            CSender tempSender = CSender.GetInstance();
            DataPacketInfo tempData = new DataPacketInfo((int)ProtocolInfo.ServerCommend, (int)ProtocolDetail.GetHostIP, 0, null);
            tempSender.Sendn(ref tempData);
        }*/
    }
    private void Update()
    {
        // 게임이 시작 되지도 않았고 서버라면
        if (!IsStartGame)
        {
            if (Network.isServer)
            {
                if (Network.connections.Length == this.PlayerLimit - 1)
                {
                    Debug.Log("Player Is Limit");
                    this.IsStartGame = true;
                    GettingStarted();
                }
            }
        }
    }
    void OnGUI()
    {
        
        // 싱글플레이시 여길 연다
        if (Network.peerType == NetworkPeerType.Disconnected)
        {
            // 게임 서버 생성 버튼+
            if (GUI.Button(new Rect(20, 20, 200, 50), "두부 캐릭터로 세팅"))
            {
                MyInfoClass.GetInstance().MyCharNumb = 0;
            }
            // 게임에 접속하는 버튼
            if (GUI.Button(new Rect(20, 100, 200, 50), "만두 캐릭터 세팅"))
            {
                MyInfoClass.GetInstance().MyCharNumb = 1;
            }
            if (GUI.Button(new Rect(20, 180, 200, 50), "호스트"))
            {
                Network.InitializeServer(20, port, _useNat);
            }
            if (GUI.Button(new Rect(20, 260, 200, 50), "로컬 접속"))
            {
                Network.Connect("127.0.0.1",port);
            }
        }
    }
    // 호스트 아이피를 찾는다.
    public void SetHostIP(string hostip)
    {
        OtherIP = hostip;
        Debug.Log("접속해야 하는 호스트 번호" + OtherIP);
        StartConnect();
    }
    private void StartConnect()
    {
        NetworkConnectionError errorCode = NetworkConnectionError.ConnectionFailed;

        // 내가 호스트가 아닐경우
        if (OtherIP != MyIP)
        {
            while (errorCode == NetworkConnectionError.NoError)
            {
                errorCode = Network.Connect(OtherIP, port);
                if(errorCode == NetworkConnectionError.AlreadyConnectedToServer
                    || errorCode == NetworkConnectionError.AlreadyConnectedToAnotherServer)
                {
                    // 연결을 끊고 자기자신을 불러온다.
                    Network.Disconnect();
                    this.StartConnect();
                }
            }
        }
        // 내가 호스트인경우
        else
        {
            errorCode = Network.InitializeServer(20, port, _useNat);
            // 만약 이미 연결된 서버가 있다면
            if (errorCode == NetworkConnectionError.AlreadyConnectedToAnotherServer ||
                errorCode == NetworkConnectionError.AlreadyConnectedToServer)
            {
                // 연결을 끊고 자기자신을 불러온다.
                Network.Disconnect();
                this.StartConnect();
            }
        }
    }


    // 게임 서버로 구동시키고 서버 초기화가 정상적으로 완료됐을 때 자동 호출됨
    void OnServerInitialized()
    {
        CreatePlayer();
        
    }

    // 클라이언트로 게임 서버에 접속했을 때 자동 호출됨.
    void OnConnectedToServer()
    {
        CreatePlayer();
    }

    // 플레이어를 생성하는 함수
    void CreatePlayer()
    {

        Vector3 pos = PlayerCreatePosition[MyInfoClass.GetInstance().MyGameNumb];
        // 네트워크 상에 플레이어를 동적 생성
        // 현재 게임에 접속한 모든 사용자에게 프리팹을 생성해주며 내부적으로 Buffered RPC를 호출해 나중에 접속한
        // 사용자도 미리 생성된 프리팹을 볼 수 있다.
        // Network.Instantiate(프리펩, 생성위치, 각도, 그릅) 
        // 그릅을 지정하면 그릅에만 생성되게 할 수 있다.
        MyPlayer = Network.Instantiate(player[MyInfoClass.GetInstance().MyCharNumb], pos, Quaternion.identity, 0) as GameObject;
    }
    // 모든 플레이어가 준비가 되었는지를 확인한다.
    public void GettingStarted()
    {
        // 플레이어들에게 시작하라고 명ㄹ령을 내린다.
        MyPlayer.GetComponent<Transform>().GetComponent<CharacterMgr>().SetStarted();
    }
    // 접속이 종료된 플레이어의 네트워크 객체를 모두 소멸 처리
    void OnPlayerDisconnected(NetworkPlayer netPlayer)
    {
        // 네트워크 플레이어의 모든 Buffered RPC를 소멸 처리
        Network.RemoveRPCs(netPlayer);
        // 네트워크 플레이어의 모든 네트워크 객체를 소멸 처리(게임 서버가 구동되고 있어야 이용 가능)
        Network.DestroyPlayerObjects(netPlayer);
    }
}