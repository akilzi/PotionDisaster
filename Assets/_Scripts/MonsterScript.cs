using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterScript : Photon.MonoBehaviour
{

    //public GameObject ThisIsMe;
    public GameObject CountManager;
    public GameObject[] EnemyPrefabs;
    public GameObject GameManager;
    private GameController _gameController;
    private float _timerLength = 1f;
    private float _DuptimerLength = 1f;
    public List<GameObject> SpawnedEnemies;
    private CharacterSelect _characterSelect;

    void Awake()
    {

    }

    // Use this for initialization
    void Start()
    {
        _characterSelect = GameObject.Find("CharacterSelect").GetComponent<CharacterSelect>();
        GameManager = GameObject.FindGameObjectWithTag("GameController");
        _gameController = GameManager.GetComponent<GameController>();
        StartCoroutine(EnemySpawner());
        //StartCoroutine(EnemyReplicator());
    }

    // Update is called once per frame
    void Update()
    {
        if (_gameController.GetEnemyCount() < 10)
        {
            _timerLength = 1f;
        }
        else if (_gameController.GetEnemyCount() < 20)
        {
            _timerLength = 1.5f;
        }
        else if (_gameController.GetEnemyCount() < 30)
        {
            _timerLength = 2f;
        }
        else if (_gameController.GetEnemyCount() < 40)
        {
            _timerLength = 3f;
        }
        else if (_gameController.GetEnemyCount() >= 40)
        {
            _timerLength = 10f;
        }

        //

        if (_gameController.GetEnemyCount() < 10)
        {
            _DuptimerLength = 1.5f;
        }
        else if (_gameController.GetEnemyCount() < 20)
        {
            _DuptimerLength = 1.8f;
        }
        else if (_gameController.GetEnemyCount() < 30)
        {
            _DuptimerLength = 2f;
        }
        else if (_gameController.GetEnemyCount() < 40)
        {
            _DuptimerLength = 2.5f;
        }
        else if (_gameController.GetEnemyCount() >= 40)
        {
            _DuptimerLength = 4f;
        }
    }

    IEnumerator EnemySpawner()
    {
        while (_gameController.GameState == GameState.PLAYING && _gameController.CharacterType == CharacterOptions.GUNNER)
        {
            for (float timer = _timerLength; timer >= 0; timer -= Time.deltaTime)
                yield return 0;

            //Select Random Enemy
            string randomEnemyName = EnemyPrefabs[Random.Range(0, EnemyPrefabs.Length)].name;

            //Set Random Location In Camera For Enemy To Spawn
            float y = Random.Range(5.9f, 6f);
            float x = Random.Range(-7f, 7f);
            GameObject randomEnemy = PhotonNetwork.Instantiate(randomEnemyName, new Vector3(x, y), Quaternion.identity,
                0);
            _gameController.AddEnemy(randomEnemy);

            randomEnemy = PhotonNetwork.Instantiate(randomEnemyName, new Vector3(x, y), Quaternion.identity,
                0);
            _gameController.AddEnemy(randomEnemy);


            randomEnemy = PhotonNetwork.Instantiate(randomEnemyName, new Vector3(x, y), Quaternion.identity,
                0);
            _gameController.AddEnemy(randomEnemy);
        }
    }
    IEnumerator EnemyReplicator()
    {
        while (_gameController.GameState == GameState.PLAYING)
        {
            for (float timer = _DuptimerLength; timer >= 0; timer -= Time.deltaTime)
                yield return 10;

            //Select Random Enemy
            GameObject randomEnemy = GameObject.FindWithTag("BadGuy");

            //Set Random Location In Camera For Enemy To Spawn
            //float y = Random.Range (5.9f, 6f);
            //float x = Random.Range (-7f, 7f);
            //randomColor.transform.position;
            Instantiate(randomEnemy, randomEnemy.transform.position, randomEnemy.transform.rotation);
            _gameController.AddEnemy(randomEnemy);

            //randomColor.transform.position; 
            Instantiate(randomEnemy, randomEnemy.transform.position, randomEnemy.transform.rotation);
            _gameController.AddEnemy(randomEnemy);


            //randomColor.transform.position;
            Instantiate(randomEnemy, randomEnemy.transform.position, randomEnemy.transform.rotation);
            _gameController.AddEnemy(randomEnemy);
        }
    }
}