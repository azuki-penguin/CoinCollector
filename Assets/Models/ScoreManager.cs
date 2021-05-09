using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Models
{
    public class ScoreManager : MonoBehaviour
    {
        private GameObject ScoreText;
        public static ScoreModel Score = ScoreModel.GetInstance();

        // Start is called before the first frame update
        void Start()
        {
            ScoreText = GameObject.Find("Score");
            Score.ResetPoint();
        }

        // Update is called once per frame
        void Update()
        {
            ScoreText.GetComponent<Text>().text = $"Score: {Score.Total}";
        }

        public void AddPoint()
        {
            Score.AddPoint();
        }
    }
}

