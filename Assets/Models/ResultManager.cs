using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Models
{
    public class ResultManager : MonoBehaviour
    {
        private GameObject ResultText;

        // Start is called before the first frame update
        void Start()
        {
            ResultText = GameObject.Find("Result");
            var score = ScoreManager.Score.Total;
            ResultText.GetComponent<Text>().text = $"Score: {score}";
        }
   }
}

