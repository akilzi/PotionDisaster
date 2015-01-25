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

public class GameController : MonoBehaviour
{


    public static GameController Instance;
    public GameState GameState;

    void Awake()
    {
        
    }

	// Use this for initialization
	void Start ()
	{
        DontDestroyOnLoad(this);
	    GameState = GameState.STARTING;
	}
	
	// Update is called once per frame
	void Update () 
    {
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

    private void ChangeState(GameState nextState)
    {
        GameState = nextState;
    }
}
