using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenMode : MonoBehaviour
{
    // 원하는 창 모드 해상도 설정
    public int screenWidth = 1280;
    public int screenHeight = 720;

    void Start()
    {
        // 스크린 해상도 설정 (창 모드)
        Screen.SetResolution(screenWidth, screenHeight, false);
    }
}
