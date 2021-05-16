using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Controllers
{
    public class CreditSceneController : MonoBehaviour
    {
        public void BackToTitle()
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}

