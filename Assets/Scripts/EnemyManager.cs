using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    //Array of prefabs (GameObject)
    public GameObject[] enemyPrefabs;
    public Enemy curEnemy;
    public Transform canvas;
    public static EnemyManager instance;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }
    void CreateNewEnemy()
    {
        GameObject enemyToSpawn = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
        GameObject obj = Instantiate(enemyToSpawn, canvas);
        // search for the Enemy script inside obj and pass it to the curEnemy variable
        curEnemy = obj.GetComponent<Enemy>();
    }


    public void DefeatEnemy(GameObject enemy)
    {
        Destroy(enemy);
        CreateNewEnemy();
        GameManager.instance.BackgroundCheck();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
