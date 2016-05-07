using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class Score : MonoBehaviour {

   
    public List<Sprite> spriteDigits = null;
    public Image Img_DigiHund, Img_DigiTens, Img_DigiOnes = null;
    public Image Img_HighDigiHund, Img_HighDigiTens, Img_HighDigiOnes = null;

    public static int totalScore = 0;
    public static bool isHighScoreSet = false;

    public GameObject gameOverText = null;

    void Awake() {

        SetScore(PlayerPrefs.GetInt("HighScore"), Img_HighDigiHund, Img_HighDigiTens, Img_HighDigiOnes);

    }
	
	public void SetScore(int score, Image hundreds, Image tens, Image ones) {

        char[] temp = Convert.ToString(score).ToCharArray();
        List<string> digits = new List<string>();

        for(int i = 0; i < temp.Length; i++) {
            digits.Add(temp[i].ToString());
        }

        if(score > 0 && score < 10) {
            if(ones != null) {
                ones.sprite = spriteDigits[Convert.ToInt32(digits[0])];
            }
        }
        else if (score > 9 && score < 100) {

            if (ones != null) {
                ones.sprite = spriteDigits[Convert.ToInt32(digits[1])];
            }
            
            if (tens != null) {
                tens.sprite = spriteDigits[Convert.ToInt32(digits[0])];
            }
        }
        else if (score > 99 && score < 1000) {

            if (ones != null) {
                ones.sprite = spriteDigits[Convert.ToInt32(digits[2])];
            }

            if (tens != null) {
                tens.sprite = spriteDigits[Convert.ToInt32(digits[1])];
            }

            if (hundreds != null) {
                hundreds.sprite = spriteDigits[Convert.ToInt32(digits[0])];
            }
        }

    }

    public void SetHighScore() {

        isHighScoreSet = true;

        if (totalScore > PlayerPrefs.GetInt("HighScore")) {

            PlayerPrefs.SetInt("HighScore", totalScore);
            SetScore(PlayerPrefs.GetInt("HighScore"), Img_HighDigiHund, Img_HighDigiTens, Img_HighDigiOnes);
            totalScore = 0;
        }

    }

}
