using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerController : MonoBehaviour
{
    public float timeLimit = 60f; // Waktu limit permainan dalam detik
    private float currentTime; // Waktu saat ini dalam detik
    private bool isTimerRunning = true; // Apakah timer sedang berjalan?
    [SerializeField] TextMeshProUGUI timerText; // Referensi teks UI untuk menampilkan timer
    public GameObject gameOverPanel;

    private void Start()
    {
        currentTime = timeLimit; // Set waktu saat ini ke waktu limit awal
    }

    private void Update()
    {
        if (isTimerRunning)
        {
            // Kurangi waktu saat ini berdasarkan waktu dalam permainan
            currentTime -= Time.deltaTime;

            // Pastikan waktu tidak kurang dari nol
            if (currentTime <= 0f)
            {
                currentTime = 0f;
                isTimerRunning = false;
                GameOver(); // Panggil fungsi GameOver saat timer habis
            }

            // Tampilkan waktu dalam teks UI
            UpdateTimerUI();
        }
    }

    private void UpdateTimerUI()
    {
        // Konversi waktu dalam detik menjadi format menit:detik (MM:SS)
        int minutes = Mathf.FloorToInt(currentTime / 60f);
        int seconds = Mathf.FloorToInt(currentTime % 60f);

        // Perbarui teks UI
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    private void GameOver()
    {
        // Tambahkan logika game over di sini
        // Misalnya, menampilkan panel game over dan menjeda permainan.

        ShowGameOverPanel(); // Menampilkan panel game over
        Time.timeScale = 0f; // Menghentikan waktu dalam permainan

        // Tambahan logika lainnya sesuai dengan game Anda
    }

    private void ShowGameOverPanel()
    {
        gameOverPanel.SetActive(true);
    }

    private void HideGameOverPanel()
    {
        gameOverPanel.SetActive(false);
    }
}
