using UnityEngine;

public enum GameState
{
    STARTING,
    INITIALIZING,
    MENU,
    PLAYING,
    PAUSED,
    EXITING
};

public class GameController : Photon.MonoBehaviour
{
	
    public static GameController Instance;
    public GameState GameState;

    void Awake()
    {
        PhotonNetwork.autoJoinLobby = false;
    }

	// Use this for initialization
	void Start ()
	{
        DontDestroyOnLoad(this);
	    GameState = GameState.STARTING;
        NextState();
	}
	
	// Update is called once per frame
	void Update () 
    {
        Debug.Log(PhotonNetwork.connectionStateDetailed.ToString());
	    if (Input.GetKeyDown(KeyCode.Escape))
	    {
	        NextState();
	    }
	}

    public void NextState()
    {
        switch (GameState)
        {
            case GameState.STARTING:
                GameState = GameState.INITIALIZING;
                StartNetworking();
                break;
            case GameState.INITIALIZING:
                GameState = GameState.PLAYING;
                Application.LoadLevel("labScene");
                break;
            case GameState.PLAYING:
                GameState = GameState.EXITING;

                //TODO: Do any clean up we need to do
                Debug.Log("QUITTING!");
                Application.LoadLevel("EndScene");
                break;
            case GameState.EXITING:
                GameState = GameState.PLAYING;
                Application.LoadLevel("labScene");
                break;
        }
    }

    private void StartNetworking()
    {
        PhotonNetwork.logLevel = PhotonLogLevel.Full;
        PhotonNetwork.ConnectUsingSettings("v0.1");
    }

    void OnPhotonCreateRoomFailed()
    {
        Debug.Log("Failed To Create Room");
    }

    void OnPhotonJoinRoomFailed()
    {
        PhotonNetwork.CreateRoom("KinskiiTest", new RoomOptions() { maxPlayers = 2 }, null);
        //PhotonNetwork.JoinRoom("KinskiiTest");
    }

    void OnConnectedToMaster()
    {
        PhotonNetwork.JoinRoom("KinskiiTest");
    }

    void OnJoinedRoom()
    {
        Debug.Log("List of other players in room");
        foreach (var photonPlayer in PhotonNetwork.otherPlayers)
        {
            Debug.Log(photonPlayer.ToString());
        }
    }
}
