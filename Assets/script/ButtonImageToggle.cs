using UnityEngine;
using UnityEngine.UI;

public class ButtonImageToggle : MonoBehaviour
{
    public Sprite image1; // รูปภาพที่ต้องการแสดงเมื่อปุ่มไม่ถูกกด
    public Sprite image2; // รูปภาพที่ต้องการแสดงเมื่อปุ่มถูกกด

    private Image buttonImage; // Reference ไปยัง Image Component ของปุ่ม

    private bool isImage1 = true; // ตัวแปรเก็บสถานะของรูปภาพปัจจุบัน

    private void Start()
    {
        buttonImage = GetComponent<Image>(); // ดึงค่า Image Component จากปุ่ม
    }

    public void ToggleImage()
    {
        // ทำการสลับรูปภาพระหว่าง image1 และ image2
        if (isImage1)
        {
            buttonImage.sprite = image2; // เปลี่ยนรูปภาพเป็น image2
        }
        else
        {
            buttonImage.sprite = image1; // เปลี่ยนรูปภาพเป็น image1
        }

        isImage1 = !isImage1; // สลับสถานะของรูปภาพ
    }
}
