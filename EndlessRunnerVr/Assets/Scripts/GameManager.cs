using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] float score;
    [SerializeField] float spawnInterval;
    [SerializeField] byte lifes;
    [SerializeField] Spawner spawner;
    public float Score { get => score; }
    public float Lifes { get => lifes; }

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        StartCoroutine(SpawnRoutine());
    }
    IEnumerator SpawnRoutine()
    {
        if (spawner == null)
        {
            yield return null;
            yield break;
        }
        while (true)
        {
            spawner.Spawn();
            yield return new WaitForSeconds(spawnInterval);
        }
    }
        // Update is called once per frame
    void Update()
    {
          score += Time.deltaTime;
    }
    public void ReduceLife()
    {
        lifes--;
    }
    public void CoinPick()
    {
        score += 10;
    }
    public void PillPick()
    {
        lifes++;
    }
}
