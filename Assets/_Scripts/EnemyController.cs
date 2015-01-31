using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{

    public GameObject coins;
    public EntityColor EnemyColor;

    private GameController _gameController;

    // Use this for initialization
    void Start()
    {
        _gameController = GameObject.Find("GameManager").GetComponent<GameController>();
    }

    public void OnCollisionEnter2D(Collision2D node)
    {
        if (node.gameObject.tag == "Bullet" && node.gameObject.GetComponent<BulletController>().BulletColor == EnemyColor)
        {
            _gameController.RemoveEnemy(gameObject);
            Instantiate(coins, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
