using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    // �w�q����ҹ��
    public static MusicController instance; 

    // ���T��
    public AudioClip sound_clickBtn;
    public AudioClip soundEffect;

    private AudioSource audioSource;

    void Awake()
    {
        // �T�O����ҼҦ�
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        // �T�O�� GameObject �b���������ɤ��Q�P��
        DontDestroyOnLoad(gameObject);

        // ��l�ƭ����ե�
        audioSource = GetComponent<AudioSource>();
    }

    // ���񭵮�
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
