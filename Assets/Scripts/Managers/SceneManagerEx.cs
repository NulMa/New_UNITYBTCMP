using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerEx : Managers
{
    public BaseScene CurrentScene
    {
        get
        {
            return GameObject.FindFirstObjectByType<BaseScene>();
        }

    }


    public void LoadScene(Define.Scene type)
    {
        SceneManager.LoadScene(type.ToString());
    }
}
