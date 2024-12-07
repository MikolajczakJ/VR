using System.Collections;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayScore : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI m_textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_textMeshPro.text = $"Score: {Math.Round((decimal)GameManager.Instance?.Score,0)}\nLifes: {GameManager.Instance?.Lifes}\nAmmo: {GameManager.Instance?.currentAmmo}/{GameManager.Instance?.magSize}";
    }
}
