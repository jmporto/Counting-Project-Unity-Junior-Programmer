using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    private int points = 0;
    public TMP_Text scoreText;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        UpdateUI(); // Atualiza a UI para mostrar a pontuação inicial de 0.
    }

    public void AddPoint()
    {
        points++;
        Debug.Log("Score: " + points);
        UpdateUI();
    }

    void UpdateUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + points.ToString();
        }
    }

    public int Getpoints()
    {
        return points;
    }
}
