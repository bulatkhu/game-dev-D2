using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    void Start() 
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    
    public void StartLevel1()
    {
        SceneManager.LoadScene("Scenes/World 1");
    }
    
    public void StartLevel2()
    {
        SceneManager.LoadScene("Scenes/World 2");
    }
    
    public void StartLevel3()
    {
        SceneManager.LoadScene("Scenes/World 3");
    }
}
