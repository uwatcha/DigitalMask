using UnityEngine;
using UnityEngine.UI;

public class DropdownController : MonoBehaviour
{
    public Dropdown dropdown;

    void Start()
    {
        // Dropdownが存在するか確認
        if (dropdown != null)
        {
            // Dropdownの選択が変更されたときのイベントにメソッドを追加
            dropdown.onValueChanged.AddListener(delegate {
                DropdownValueChanged(dropdown);
            });
        }
        else
        {
            Debug.LogError("Dropdownがアタッチされていません。");
        }
    }

    void DropdownValueChanged(Dropdown change)
    {
        // Dropdownの現在の選択値を取得
        int selectedValue = dropdown.value;

        // 選択値を表示（この行は必要に応じて変更または削除できます）
        Debug.Log("選択された値: " + selectedValue);
    }
}
