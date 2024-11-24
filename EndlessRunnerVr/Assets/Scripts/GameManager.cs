using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] float score;
    [SerializeField] byte lifes;
    public float Score { get => score; }
    public float Lifes { get => lifes; }

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
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
}
