using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    // 定義為單例實例
    public static MusicController instance; 

    // 音訊檔
    public AudioClip sound_clickBtn;
    public AudioClip soundEffect;

    private AudioSource audioSource;

    void Awake()
    {
        // 確保為單例模式
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        // 確保此 GameObject 在場景切換時不被銷毀
        DontDestroyOnLoad(gameObject);

        // 初始化音源組件
        audioSource = GetComponent<AudioSource>();
    }

    // 播放音效
    public void PlaySoundEffect(string str)
    {
        switch(str)
        {
            case "clickBtn":
                audioSource.PlayOneShot(sound_clickBtn);
                break;
            default:
                Debug.LogError(str);
                break;
        }
    }
}
