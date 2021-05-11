using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Controllers
{
    public class ManualSceneController : MonoBehaviour
    {
        public void BackToTitle()
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}

