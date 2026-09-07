using UnityEngine;
using TMPro; // Library untuk TextMeshPro (Wajib untuk tantangan nilai +)

public class GameManager : MonoBehaviour
{
    public int totalKoin;
    private int koinTerkumpul = 0;

    // Tambahan untuk bonus UI Text
    public TextMeshProUGUI teksSkor;
    public GameObject teksMenang;

    void Start()
    {
        // TODO: hitung jumlah koin di scene saat mulai
        totalKoin = GameObject.FindGameObjectsWithTag("Coin").Length;

        // Setup awal UI
        if (teksMenang != null) teksMenang.SetActive(false);
        UpdateSkorUI();
    }

    public void AmbilKoin()
    {
        koinTerkumpul++;
        UpdateSkorUI();

        // TODO: jika koinTerkumpul == totalKoin, panggil Menang()
        if (koinTerkumpul == totalKoin) 
        {
            Menang();
        }
    }

    void UpdateSkorUI()
    {
        if (teksSkor != null)
        {
            teksSkor.text = "Skor: " + koinTerkumpul;
        }
    }

    void Menang()
    {
        Debug.Log("KAMU MENANG!");

        // Tampilkan teks menang di layar game (Bonus nilai +)
        if (teksMenang != null)
        {
            teksMenang.SetActive(true);
        }
    }
}