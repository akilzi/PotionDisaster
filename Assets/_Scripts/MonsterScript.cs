using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterScript : MonoBehaviour {
	
	//public GameObject ThisIsMe;
	public GameObject CountManager;
    public GameObject[] EnemyPrefabs;
    public GameObject GameManager;
    private GameController _gameController;
    private float _timerLength = 1f;
    public List<GameObject> SpawnedEnemies;
    private CountManager _countManager;

    void Awake()
    {
        
    }

	// Use this for initialization
	void Start ()
	{
        _countManager = CountManager.GetComponent<CountManager>();
        GameManager = GameObject.FindGameObjectWithTag("GameController");
        _gameController = GameManager.GetComponent<GameController>();
        StartCoroutine(EnemySpawner());
	}
	
	// Update is called once per frame
	void Update () 
    {
	    if (_countManager.totalEnemiesInt < 10)
	    {
	        _timerLength = 1f;
	    }
        else if (_countManager.totalEnemiesInt < 20)
        {
            _timerLength = 1.5f;
        }
        else if (_countManager.totalEnemiesInt < 30)
        {
            _timerLength = 2f;
        }
        else if (_countManager.totalEnemiesInt < 40)
        {
            _timerLength = 3f;
        }
        else if (_countManager.totalEnemiesInt >= 40)
        {
            _timerLength = 10f;
        }
	}

    IEnumerator EnemySpawner()
    {
        while (_gameController.GameState == GameState.PLAYING)
        {
            for (float timer = _timerLength; timer >= 0; timer -= Time.deltaTime)
                yield return 0;

            //Select Random Enemy
            GameObject randomEnemy = EnemyPrefabs[Random.Range(0, EnemyPrefabs.Length)];

            //Set Random Location In Camera For Enemy To Spawn
            float y = Random.Range(0f, 4f);
            float x = Random.Range(-7f, 7f);
            randomEnemy.transform.position = new Vector3(x, y);
            Instantiate(randomEnemy);
            CountManager.GetComponent<CountManager>().addEnemy(randomEnemy);

            randomEnemy.transform.position = new Vector3(x, y);
            Instantiate(randomEnemy);
            CountManager.GetComponent<CountManager>().addEnemy(randomEnemy);


            randomEnemy.transform.position = new Vector3(x, y);
            Instantiate(randomEnemy);
            CountManager.GetComponent<CountManager>().addEnemy(randomEnemy);
        }
    }
}