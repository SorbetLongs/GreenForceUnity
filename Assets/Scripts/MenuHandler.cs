using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public void başla() {
        SceneManager.LoadScene("SampleScene");
    }

    public void çık() {
        Application.Quit();
    }
}
