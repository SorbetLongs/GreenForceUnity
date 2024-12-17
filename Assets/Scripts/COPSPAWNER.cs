using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using UnityEngine.InputSystem.Controls;

public class COPSPAWNER : MonoBehaviour
{
    public int copid = 0;
    public int sayaç = 10;
    public int skor = 0;
    public TextMeshProUGUI sayaçtext;
    public TextMeshProUGUI dytext;
    public TextMeshProUGUI dtext;
    public GameObject gameover;
    public GameObject Tutorials;
    public bool enable = true;
    public SpriteRenderer çöp;
    public Sprite plastik;
    public Sprite kağıt;
    public Sprite cam;
    public Sprite metal;
    public GameObject sprites;
    public Color yanlışrenk;
    public Color doğrurenk;
    public Color notrrenk;
    public float sürehızı = 1;
    public int sayac = 0;

    public void Start()
    {
        sayaçtext.text = sayaç.ToString();
    }

    public void başlat()
    {
        enable = true;
        Invoke("süreeksilt", sürehızı);
        çöpdeğiş();
    }

    void Update()
    {
        if(sayaç <= 0) {
            gameover.SetActive(true);
            enabled = false;
            sayaç = 0;
        }
        else if(sayaç <= 7) {
            sayaçtext.color = yanlışrenk;
        }
        else if(sayaç > 7) {
            sayaçtext.color = notrrenk;
        }

        if(Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }

        if(Input.GetKeyDown(KeyCode.Tab)) {
            Tutorial();
        }
    }

    public void çöpdeğiş() {
        copid = Random.Range(0 , 4);
        Debug.Log(copid);
        if(copid == 0) {
            çöp.sprite = kağıt;
            sprites.transform.localScale = new Vector2(0.6f,0.6f);
        }
        else if(copid == 1) {
            çöp.sprite = plastik;
            sprites.transform.localScale = new Vector2(0.2f,0.2f);
        }
        else if(copid == 2) {
            çöp.sprite = cam;
            sprites.transform.localScale = new Vector2(0.6f,0.6f);
        }
        else if(copid == 3) {
            çöp.sprite = metal;
            sprites.transform.localScale = new Vector2(1f,1f);
        }
    }

    public void yenidenbaşla() {
        enabled = true;
        sayaç = 10;
        sürehızı = 1;
        gameover.SetActive(false);
        Invoke("süreeksilt", sürehızı);
    }

    public void Tutorial() {
        skor = 0;
        Tutorials.SetActive(true);
        sayaç = 10;
        sürehızı = 1;
        enable = false;
    }

    public void çık() {
        Application.Quit();
    }

    public void süreeksilt() {
        if(sayaç > 0 && enable == true) {
            sayaç -= 1;
            sayaçtext.text = sayaç.ToString();
            Debug.Log(sayaç);
            Invoke("süreeksilt", sürehızı);
        }
    }
}
