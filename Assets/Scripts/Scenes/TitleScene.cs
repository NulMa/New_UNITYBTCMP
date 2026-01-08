using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene : BaseScene
{
    protected override void Init()
    {
        base.Init();
        SceneType = Define.Scene.Title;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Managers.Scene.LoadScene(Define.Scene.Game);
            //Managers.Scene.LoadScene(Define.Scene.Game);
            //SceneManager.LoadScene("Game");
        }
    }

    public override void Clear()
    {
        Logger.Log("TitleScene Clear");
    }
}
