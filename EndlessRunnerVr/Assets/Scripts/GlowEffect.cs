using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowEffect : MonoBehaviour
{
    [SerializeField] private Renderer objectRenderer;
    [SerializeField] private Color glowColor = Color.magenta; // Domy�lny kolor po�wiaty
    [SerializeField] private float glowSpeed = 2f; // Szybko�� animacji
    private Material material;
    private float glowIntensity;

    void Start()
    {
        if (objectRenderer == null)
        {
            objectRenderer = GetComponent<Renderer>();
        }

        if (objectRenderer != null)
        {
            material = objectRenderer.material;
            material.EnableKeyword("_EMISSION");
        }
    }

    void Update()
    {
        if (material != null)
        {
            // Oscylowanie intensywno�ci po�wiaty
            glowIntensity = Mathf.PingPong(Time.time * glowSpeed, 0.5f);
            material.SetColor("_EmissionColor", glowColor * glowIntensity);
        }
    }
}

