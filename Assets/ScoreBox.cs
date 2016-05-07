using UnityEngine;
using System.Collections;

public class ScoreBox : MonoBehaviour {


    public Score scoreObject = null;
    
    void OnTriggerEnter2D(Collider2D collider) {
        {
            Score.totalScore++;
            scoreObject.SetScore(Score.totalScore, scoreObject.Img_DigiHund, scoreObject.Img_DigiTens, scoreObject.Img_DigiOnes);
        }
    }


}
