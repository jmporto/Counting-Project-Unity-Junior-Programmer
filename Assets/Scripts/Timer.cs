using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float initialTimer = 60f; // Tempo inicial em segundos.
    private float currentTimer;
    public TMP_Text timerText; // Referência ao UI Text para mostrar o tempo restante.

    void Start()
    {
        currentTimer = initialTimer;
        UpdateUI();
    }

    void Update()
    {
        // Diminui o tempo ao longo do tempo.
        currentTimer -= Time.deltaTime;
        UpdateUI();

        // Verifica se o tempo acabou.
        if (currentTimer <= 0)
        {
            currentTimer = 0;
            GameOver();
        }
    }

    void UpdateUI()
    {
        if (timerText != null)
        {
            timerText.text = "Time Left: " + Mathf.Ceil(currentTimer).ToString();
        }
    }

    void GameOver()
    {
        Debug.Log("Game Over!");
    }

}
