using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageFlipper : MonoBehaviour
{
    public RectTransform content; // 顯示內容的RectTransform
    public float pageWidth = 1080f; // 每頁的寬度
    public float animationDuration = 0.5f; // 翻頁動畫持續時間
    public int totalPages = 3; // 總頁數
    private int currentPage = 0; // 當前頁數

    private void Start()
    {
        // 初始化顯示第一頁
        ShowPage(currentPage);
    }

    public void NextPage()
    {
        // 如果不是最後一頁，則顯示下一頁
        if (currentPage < totalPages - 1)
        {
            currentPage++;
            ShowPage(currentPage);
        }
    }

    public void PreviousPage()
    {
        // 如果不是第一頁，則顯示上一頁
        if (currentPage > 0)
        {
            currentPage--;
            ShowPage(currentPage);
        }
    }

    private void ShowPage(int pageNum)
    {
        // 計算目標位置
        Vector2 targetPos = new Vector2(-pageNum * pageWidth, content.anchoredPosition.y);
        // 使用動畫過渡到目標位置
        StartCoroutine(AnimatePage(targetPos));
    }

    private IEnumerator AnimatePage(Vector2 targetPos)
    {
        float elapsedTime = 0f;
        Vector2 startPos = content.anchoredPosition;

        while (elapsedTime < animationDuration)
        {
            content.anchoredPosition = Vector2.Lerp(startPos, targetPos, elapsedTime / animationDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        content.anchoredPosition = targetPos; // 確保到達準確的目標位置
    }
}
