using System.Collections.Generic;
using UnityEngine;
using TMPro; // dùng cho TextMeshPro

public class GameHistory : MonoBehaviour
{
    public TMP_Text historyText; // kéo HistoryText vào đây
    private List<int> lastScores = new List<int>();

    public void SaveScore(int score)
    {
        // Thêm điểm mới vào đầu danh sách
        lastScores.Insert(0, score);

        // Giữ tối đa 3 ván
        if (lastScores.Count > 3)
        {
            lastScores.RemoveAt(lastScores.Count - 1);
        }

        UpdateHistoryUI();
    }

    private void UpdateHistoryUI()
    {
        if (historyText == null) return;

        historyText.text = "Lịch sử 3 ván gần nhất:\n";
        for (int i = 0; i < lastScores.Count; i++)
        {
            historyText.text += $"Ván {i + 1}: {lastScores[i]}\n";
        }
    }
}
