using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [System.Serializable]
    public class Pool
    {
        public GameObject prefab;
        public string tag;
        public int InitialPoolSize;
    }
    [SerializeField] Transform spawnPoint1, spawnPoint2;
    public List<Pool> pools = new List<Pool>();
    public Dictionary<string, Queue<GameObject>> poolDict = new Dictionary<string, Queue<GameObject>>();
    // Start is called before the first frame update
    void Start()
    {
        foreach (var pool in pools)
        {
            Queue<GameObject> poolQueue = new Queue<GameObject>();
            GameObject  poolParent = new GameObject(pool.tag);
            for (int i = 0; i < pool.InitialPoolSize; i++)
            {
                GameObject poolableObject = Instantiate(pool.prefab,poolParent.transform);
                poolQueue.Enqueue(poolableObject);
                poolableObject.SetActive(false);
            }
            poolDict.Add(pool.tag, poolQueue);
        }
    }
    public void Spawn()
    {
        int numb = UnityEngine.Random.Range(0, pools.Count);
        string  tag = pools[numb].tag;
        if (poolDict.TryGetValue(tag, out Queue<GameObject> pool))
        {
            GameObject spawned = pool.Dequeue();
            spawned.SetActive(true);
            spawned.transform.position = Vector3.Lerp(spawnPoint1.position, spawnPoint2.position, UnityEngine.Random.Range(0,1f)) ;
            pool.Enqueue(spawned);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
