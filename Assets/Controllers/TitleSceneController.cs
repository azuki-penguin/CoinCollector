using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Controllers
{
    public class TitleSceneController : MonoBehaviour
    {
        private GameObject VersionText;

        void Start()
        {
            VersionText = GameObject.Find("VersionText");
            VersionText.GetComponent<Text>().text = $"ver. {Application.version}";
        }

        public void PlayGame()
        {
            SceneManager.LoadScene("GameScene");
        }

        public void ShowManual()
        {
            SceneManager.LoadScene("ManualScene");
        }

        public void ShowCredit()
        {
            SceneManager.LoadScene("CreditScene");
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }
}

