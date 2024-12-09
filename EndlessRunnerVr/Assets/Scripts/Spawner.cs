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
        Debug.Log("Attempting to spawn...");
        int numb = UnityEngine.Random.Range(0, pools.Count);
        string  tag = pools[numb].tag;
        if (poolDict.TryGetValue(tag, out Queue<GameObject> pool))
        {
            GameObject spawned = pool.Dequeue();
            spawned.SetActive(true);
            if (tag.ToLower() == "barrier")
            {
                spawned.transform.position =new Vector3(78.31f,0,0);
            }
            else
            {
                spawned.transform.position = Vector3.Lerp(spawnPoint1.position, spawnPoint2.position, UnityEngine.Random.Range(0,1f)) ;

            }

            pool.Enqueue(spawned);
            Debug.Log($"Spawned object with tag: {tag}");
        }
        else
        {
            Debug.LogWarning($"No pool found for tag: {tag}");
        }
    }
    public void ResetSpawner()
{
    foreach (var pool in poolDict)
    {
        foreach (var obj in pool.Value)
        {
            obj.SetActive(false); // Ustaw wszystkie obiekty jako nieaktywne
        }
    }
    Debug.Log("Spawner reset.");
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
