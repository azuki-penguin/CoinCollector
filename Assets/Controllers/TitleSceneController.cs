using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Controllers
{
    public class TitleSceneController : MonoBehaviour
    {
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

