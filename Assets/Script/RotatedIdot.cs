using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 100f; // kecepatan rotasi objek

    private bool isRotating = false;
    private Vector3 mouseStartPosition;

    void Update()
    {
        // cek jika tombol kiri mouse ditekan
        if (Input.GetMouseButtonDown(0))
        {
            // simpan posisi awal mouse
            mouseStartPosition = Input.mousePosition;
            isRotating = true;
        }

        // cek jika tombol kiri mouse dilepas
        if (Input.GetMouseButtonUp(0))
        {
            isRotating = false;
        }

        // jika sedang memutar objek
        if (isRotating)
        {
            // hitung perbedaan posisi mouse saat ini dengan posisi awal mouse
            Vector3 delta = Input.mousePosition - mouseStartPosition;

            // rotasi objek berdasarkan perbedaan posisi mouse
            transform.Rotate(Vector3.up, -delta.x * rotationSpeed * Time.deltaTime, Space.World);

            // simpan posisi mouse saat ini sebagai posisi awal mouse untuk rotasi selanjutnya
            mouseStartPosition = Input.mousePosition;
        }
    }
}