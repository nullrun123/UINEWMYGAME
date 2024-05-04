using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioSource buttonClickSound; // อ้างอิง AudioSource ที่ต้องการใช้งาน

    private void Start()
    {
        
        /*if (buttonClickSound == null)
        {
           
            buttonClickSound = GetComponent<AudioSource>();
        }*/
    }

    public void OnButtonClick()
    {
        // เล่นเสียงเมื่อกดปุ่ม
        buttonClickSound.Play();
    }
}
