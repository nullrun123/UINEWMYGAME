using UnityEngine;
using UnityEngine.UI;

public class hideandshow11 : MonoBehaviour
{
    public Image imageToShow; // ระบุ UI Image ที่ต้องการแสดงผ่าน Inspector

    private void Start()
    {
        // ตรวจสอบว่า imageToShow ถูกกำหนดหรือไม่
        if (imageToShow == null)
        {
            Debug.LogError("Please assign the Image to show in the inspector!");
        }
    }

    public void OnButtonClick()
    {
        // แสดง UI Image เมื่อปุ่มถูกกด
        imageToShow.gameObject.SetActive(true); // หรือใช้ imageToShow.enabled = true; ก็ได้
    }
}
