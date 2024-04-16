using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageFlipper : MonoBehaviour
{
    public RectTransform content; // ��ܤ��e��RectTransform
    public float pageWidth = 1080f; // �C�����e��
    public float animationDuration = 0.5f; // ½���ʵe����ɶ�
    public int totalPages = 3; // �`����
    private int currentPage = 0; // ��e����

    private void Start()
    {
        // ��l����ܲĤ@��
        ShowPage(currentPage);
    }

    public void NextPage()
    {
        // �p�G���O�̫�@���A�h��ܤU�@��
        if (currentPage < totalPages - 1)
        {
            currentPage++;
            ShowPage(currentPage);
        }
    }

    public void PreviousPage()
    {
        // �p�G���O�Ĥ@���A�h��ܤW�@��
        if (currentPage > 0)
        {
            currentPage--;
            ShowPage(currentPage);
        }
    }

    private void ShowPage(int pageNum)
    {
        // �p��ؼЦ�m
        Vector2 targetPos = new Vector2(-pageNum * pageWidth, content.anchoredPosition.y);
        // �ϥΰʵe�L���ؼЦ�m
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

        content.anchoredPosition = targetPos; // �T�O��F�ǽT���ؼЦ�m
    }
}
