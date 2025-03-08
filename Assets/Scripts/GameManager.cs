﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class GameManager : MonoBehaviour
{
<<<<<<< HEAD
    public GameObject gameOver;  // UI Game Over
    public Image ImageHP;  // Thanh máu
    public GameObject scoreUITextGO; // UI điểm số
=======
    public GameObject gameOver;
    public Image ImageHP;
    public GameObject scoreUITextGO;
>>>>>>> 1774e338774e96cf4dd5fcc0363d666d03cef8a0

    public RectTransform countdownPanel; // Thanh ngang mở rộng
    public Image countdownImage;
    public Sprite[] countdownSprites; // 3 ảnh đếm ngược

    void Start()
    {
        StartCoroutine(ExpandPanelAndCountdown());
    }

    IEnumerator ExpandPanelAndCountdown()
    {
        Time.timeScale = 0f; // Dừng game khi đếm ngược

        // Hiệu ứng mở rộng thanh ngang
        float duration = 0.5f;
<<<<<<< HEAD
        float targetHeight = 300f;
=======
        float targetHeight = 300f; // Độ cao của thanh ngang sau khi mở rộng
>>>>>>> 1774e338774e96cf4dd5fcc0363d666d03cef8a0
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.unscaledDeltaTime;
            float newHeight = Mathf.Lerp(0, targetHeight, elapsedTime / duration);
            countdownPanel.sizeDelta = new Vector2(countdownPanel.sizeDelta.x, newHeight);
            yield return null;
        }

        // Đếm ngược 3, 2, 1
        if (countdownImage != null && countdownSprites.Length > 0)
        {
            for (int i = 0; i < countdownSprites.Length; i++)
            {
                countdownImage.sprite = countdownSprites[i];
                yield return new WaitForSecondsRealtime(1f);
            }
            countdownImage.gameObject.SetActive(false);
            countdownPanel.gameObject.SetActive(false); // Ẩn panel sau khi đếm xong
        }

        Time.timeScale = 1f; // Bắt đầu game sau khi đếm ngược xong
    }

    public void UpdateHP(float currentHP, float maxHP)
    {
        if (ImageHP != null)
        {
            ImageHP.fillAmount = currentHP / maxHP;
        }
        else
        {
            Debug.LogError("⚠ Lỗi: ImageHP chưa được gán trong GameManager!");
        }
<<<<<<< HEAD

        // Kiểm tra nếu máu hết thì dừng game
        if (currentHP <= 0)
        {
            Over();
        }
=======
>>>>>>> 1774e338774e96cf4dd5fcc0363d666d03cef8a0
    }

    public void Over()
    {
<<<<<<< HEAD
        Time.timeScale = 0f; // Dừng toàn bộ game
        if (gameOver != null)
        {
            gameOver.SetActive(true);
        }
        else
        {
            Debug.LogError("⚠ Lỗi: gameOver UI chưa được gán trong GameManager!");
        }
=======
        gameOver.SetActive(true);
        Time.timeScale = 0f;
>>>>>>> 1774e338774e96cf4dd5fcc0363d666d03cef8a0
    }

    public void restart()
    {
<<<<<<< HEAD
        Time.timeScale = 1f; // Reset thời gian trước khi restart
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        // Kiểm tra nếu scoreUITextGO tồn tại
        if (scoreUITextGO != null)
        {
            scoreUITextGO.GetComponent<GameScore>().Score = 0;
        }
        else
        {
            Debug.LogError("⚠ Lỗi: scoreUITextGO chưa được gán trong GameManager!");
        }
=======
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        scoreUITextGO.GetComponent<GameScore>().Score = 0;
>>>>>>> 1774e338774e96cf4dd5fcc0363d666d03cef8a0
    }

    public void quit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
