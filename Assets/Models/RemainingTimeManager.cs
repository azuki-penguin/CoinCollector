using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Models
{
    public class RemainingTimeManager : MonoBehaviour
    {
        private float remainingTime = 60.0f;
        private GameObject remainingTimeText;

        private string RemainingTimeString =>
            $"Time\n{((int)remainingTime).ToString("D")}";

        // Start is called before the first frame update
        void Start()
        {
            remainingTimeText = GameObject.Find("RemainingTime");
            remainingTimeText.GetComponent<Text>().text = RemainingTimeString;
        }

        // Update is called once per frame
        void Update()
        {
            remainingTime -= Time.deltaTime;
            if (remainingTime < 0)
            {
                SceneManager.LoadScene("ResultScene");
            }
            else
            {
                remainingTimeText.GetComponent<Text>().text = RemainingTimeString;
            }
        }
    }
}

