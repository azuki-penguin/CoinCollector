using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Controllers
{
    public class ResultSceneController : MonoBehaviour
    {
        public void MoveToGameScene()
        {
            SceneManager.LoadScene("GameScene");
        }

        public void MoveToTitleScene()
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}

