using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inven : UI_Scene
{
    enum GameObjects
    {
        GridPanel,
        Unknown
    }
    void Start()
    {
        Init();
    }

    public override void Init()
    {
        base.Init();

        Bind<GameObject>(typeof(GameObjects));
        GameObject gridPanel = GetGameObject((int)GameObjects.GridPanel);

        foreach(Transform child in gridPanel.transform) //destroy all children of grid panel
            Managers.Resource.Destroy(child.gameObject);


        // TODO : add inven items, refer Real Datas
        //for (int i = 0; i < 20; i++)
        //{
        //    GameObject item = Managers.Resource.Instantiate("UI/SubItem/UI_InvenItem");
        //    UI_InvenItem invenItem = item.GetComponent<UI_InvenItem>();

        //    if (invenItem != null)
        //    {
        //        int rand = Random.Range(1, 3);
        //        Texture2D texture = Managers.Resource.Load<Texture2D>($"Textures/Icon{rand}");
        //        Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
        //        Button btn = item.transform.Find("ItemIcon").AddComponent<Button>(); // add button component to icon

        //        invenItem.SetInfo(sprite, $"Item_{i}");

        //        btn.gameObject.AddUIEvent((data) => { Debug.Log($"Clicked Item : {i}"); }); // add click event to button
        //        item.transform.SetParent(gridPanel.transform); //generate item and set parent

        //    }
        //}


        //
        // Fix closure issue by creating local copy of index
        //


        for (int i = 0; i < 20; i++)
        {
            GameObject item = Managers.Resource.Instantiate("UI/SubItem/UI_InvenItem");
            UI_InvenItem invenItem = item.GetComponent<UI_InvenItem>();

            if (invenItem != null)
            {
                int rand = Random.Range(1, 3);
                Texture2D texture = Managers.Resource.Load<Texture2D>($"Textures/Icon{rand}");
                Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
                Button btn = item.transform.Find("ItemIcon").AddComponent<Button>(); // add button component to icon

                invenItem.SetInfo(sprite, $"Item_{i}");

                int index = i; // local copy for closure

                btn.gameObject.AddUIEvent((data) => { Debug.Log($"Clicked Item : {index}"); }); // add click event to button
                item.transform.SetParent(gridPanel.transform); //generate item and set parent

            }
        }
    }

    void Update()
    {
        
    }
}
