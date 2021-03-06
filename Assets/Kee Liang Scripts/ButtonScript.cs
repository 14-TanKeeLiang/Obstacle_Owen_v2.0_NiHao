using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void PlayBtn()
    {
        SceneManager.LoadScene("LevelSelection");
    }

    public void InstructionBtn()
    {
        SceneManager.LoadScene("InstructionsMenu");
    }

    public void EasyLevel()
    {
        SceneManager.LoadScene("EasyLevel");
    }

    public void MediumLevel()
    {
        SceneManager.LoadScene("MediumLevel");
    }

    public void HardLevel()
    {
        SceneManager.LoadScene("HardLevel");
    }

    public void MainMenuBtn()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitBtn()
    {
        Application.Quit();
    }
}
