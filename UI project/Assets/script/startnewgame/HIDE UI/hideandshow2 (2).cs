using UnityEngine;
using UnityEngine.UI;

public class hideandshow2 : MonoBehaviour
{
    public Image imageToHide; // ระบุ UI Image ที่ต้องการซ่อนผ่าน Inspector

    private void Start()
    {
        // ตรวจสอบว่า imageToHide ถูกกำหนดหรือไม่
        if (imageToHide == null)
        {
            Debug.LogError("Please assign the Image to hide in the inspector!");
        }
    }

    public void OnButtonClick()
    {
        if(Time.timeScale == 0)
        {
            Time.timeScale = 1;
            Debug.Log("เกมทำงานต่อ");
        }
        // ซ่อน UI Image เมื่อปุ่มถูกกด
        imageToHide.gameObject.SetActive(false); // หรือใช้ imageToHide.enabled = false; ก็ได้
    }
}
