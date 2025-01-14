using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpenSceneBtn : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            SelectSfx.Instant();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        });
    }
}
