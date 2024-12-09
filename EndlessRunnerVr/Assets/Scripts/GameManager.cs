using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // Potrzebne do za³adowania sceny
using UnityEngine.UI; // Do kontrolowania UI

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private float score;
    [SerializeField] private float spawnInterval;
    [SerializeField] private byte lifes;
    [SerializeField] private Spawner spawner;
    [SerializeField] private GameObject redWall;
    [SerializeField] private TextMeshProUGUI gameOverText; // Dla TextMeshPro
    [SerializeField] private GameObject player;
    [SerializeField] private Button playAgainButton; // Przycisk "Play Again"
    [SerializeField] private Vector3 startPosition; // Pocz¹tkowa pozycja gracza
    [SerializeField] public int currentAmmo;
    [SerializeField] public int magSize;
    [SerializeField] public int maxDistance;

    private Coroutine spawnCoroutine; // Referencja do Coroutine

    public float Score { get => score; }
    public float Lifes { get => lifes; }

    void Start()
    {
        Instance = this;
        playAgainButton.gameObject.SetActive(false); // Przyciski ukryte na pocz¹tku
        ResetGame();  // Zresetuj grê na pocz¹tku
        //StartCoroutine(SpawnRoutine());
    }
    public void ResetGame()
    {
        lifes = 5;
        redWall.SetActive(false); // Ukryj czerwon¹ œcianê
        gameOverText.gameObject.SetActive(false); // Ukryj napis Game Over
        Time.timeScale = 1; // Przywróæ normalny czas
        player.transform.position = startPosition; // Reset pozycji gracza
        playAgainButton.gameObject.SetActive(false); // Ukryj przycisk na pocz¹tku

        spawner.ResetSpawner(); // Zresetuj spawner
        // Uruchomienie spawnowania od nowa
        if (spawnCoroutine != null)
        {
            StopCoroutine(spawnCoroutine); // Zatrzymaj poprzedni¹ Coroutine
        }
        spawnCoroutine = StartCoroutine(SpawnRoutine()); // Rozpocznij now¹ Coroutine
        Debug.Log("SpawnRoutine restarted.");
    }

    IEnumerator SpawnRoutine()
    {
        Debug.Log("SpawnRoutine started.");
        if (spawner == null)
        {
            Debug.LogWarning("Spawner is null!");
            //yield return null;
            yield break;
        }
        while (lifes > 0)
        {
            Debug.Log("Spawning...");
            spawner.Spawn();
            yield return new WaitForSeconds(spawnInterval);
        }
        Debug.Log("SpawnRoutine ended.");
    }

    void Update()
    {
        score += Time.deltaTime;
    }
    public void ReduceLife()
    {
        lifes--;
        Debug.Log($"Life decreased, current lifes: {lifes}");
        if (lifes <= 0)
        {
            lifes = 0;
            ShowGameOver();
        }
    }
    public void ShowGameOver()
    {
        if (redWall != null)
        {
            redWall.SetActive(true);
            Vector3 playerPosition = player.transform.position; // Pozycja gracza
            redWall.transform.position = new Vector3(playerPosition.x, 3.2f, playerPosition.z); // Ustaw œcianê w miejscu gracza
        }
        if (gameOverText != null)
        {
            gameOverText.text = "GAME OVER\nScore: " + Mathf.FloorToInt(score);
            gameOverText.gameObject.SetActive(true);
        }
        Time.timeScale = 0; // Zatrzymanie gry
        
        playAgainButton.onClick.AddListener(PlayAgain); // Dodaj funkcjê do przycisku
        playAgainButton.gameObject.SetActive(true); // Poka¿ przycisk "PLAY AGAIN"
    }
    private void PlayAgain()
    {
        playAgainButton.gameObject.SetActive(false); // Ukryj przycisk
        playAgainButton.onClick.RemoveAllListeners(); // Usuñ wszystkie eventy z przycisku
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Prze³aduj scenê
    }

    public void CoinPick()
    {
        score += 10;
    }

    public void PillPick()
    {
        //Random pill tutaj
        currentAmmo = 5;

        lifes++;
    }
    public void UseBullet()
    {
        if (currentAmmo > 0) {
            currentAmmo--;
        }
    }
}