using System.Collections;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private float score;
    [SerializeField] private float spawnInterval;
    [SerializeField] private byte lifes;
    [SerializeField] private Spawner spawner;
    [SerializeField] private GameObject redWall;
    [SerializeField] private TextMeshProUGUI gameOverText; // Dla TextMeshPro


    public float Score { get => score; }
    public float Lifes { get => lifes; }

    void Start()
    {
        Instance = this;
        if (redWall != null)
        {
            redWall.SetActive(false);
        }
        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(false);
        }
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        if (spawner == null)
        {
            yield return null;
            yield break;
        }
        while (lifes > 0)
        {
            spawner.Spawn();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void Update()
    {
        score += Time.deltaTime;
    }

    public void ReduceLife()
    {
        lifes--;
        Debug.Log("Lives left: " + lifes);

        if (lifes <= 0)
        {
            lifes = 0;
            Debug.Log("Game Over! Activating red wall.");
            if (redWall != null)
            {
                redWall.SetActive(true);
            }
            if (gameOverText != null)
            {
                gameOverText.text = "GAME OVER\nScore: " + Mathf.FloorToInt(score);
                gameOverText.gameObject.SetActive(true);
                Debug.Log("Game Over text activated!");
            }
            else
            {
                Debug.LogError("Game Over Text is not assigned!");
            }
            Time.timeScale = 0; // Zatrzymanie gry
        }
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