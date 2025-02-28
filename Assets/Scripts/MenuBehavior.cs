using UnityEngine;
using System.Collections;

public class MenuBehavior : MonoBehaviour
{
    public void goToGame() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("gameplay");
    }
}
