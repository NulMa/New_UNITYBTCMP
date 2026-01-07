using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class UI_InvenItem : UI_Base
{
    Sprite _texture;
    string _name;
    enum GameObjects
    {
        ItemIcon,
        ItemNameText,
    }


    void Start()
    {
        Init();
        
    }

    public override void Init()
    {
        Bind<GameObject>(typeof(GameObjects));
        //gameObject.GetOrAddComponent<UnityEngine.UI.Button>().onClick.AddListener(() => { Debug.Log($"Clicked {_name}"); });
        RefreshUI();

    }

    public void SetInfo(Sprite texture, string itemName)
    {
        _texture = texture;
        _name = itemName;

    }

    public void RefreshUI()
    {
        Image iconGameObject = GetGameObject((int)GameObjects.ItemIcon).GetComponent<Image>();
        if(iconGameObject == null)
        {
            Image iconImage  = GetComponent<Image>();
            iconImage.sprite = _texture;
        }
            iconGameObject.sprite = _texture;

        Text nameText = GetGameObject((int)GameObjects.ItemNameText).GetComponent<Text>();
        if(nameText == null)
        {

        }
        nameText.text = _name;
    }
    void Update()
    {
        
    }
}
