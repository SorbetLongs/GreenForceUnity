using UnityEngine;

public class KUTULAR : MonoBehaviour
{
    public int id = 0;
    public int idmax = 0;
    public COPSPAWNER Çöp;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void copbas() {
        if(Çöp.copid == id) {
            Çöp.dytext.text = " ";
            Debug.Log("Doğru");
            Çöp.çöpdeğiş();
            Çöp.skor += Random.Range(12, 23);
            Çöp.dtext.text = Çöp.skor.ToString();
            Çöp.dtext.color = Çöp.doğrurenk;
            Çöp.sayaç += Random.Range(5, 10);
            Çöp.sayaçtext.text = Çöp.sayaç.ToString();
            Çöp.dytext.text = " Doğru";
            Çöp.dytext.color = Çöp.doğrurenk;
            Çöp.sayac += 1;
            if(Çöp.sayac == 7) {
                Çöp.sürehızı *= 0.4f;
                Çöp.sayac = 0;
            }
        }
        else {
            Çöp.dytext.text = " ";
            Debug.Log("Yanlış");
            Çöp.çöpdeğiş();
            Çöp.skor -= Random.Range(7, 14);
            Çöp.dtext.text = Çöp.skor.ToString();
            Çöp.dtext.color = Çöp.yanlışrenk;
            Çöp.sayaç -= Random.Range(3, 9);
            Çöp.sayaçtext.text = Çöp.sayaç.ToString();
            Çöp.dytext.text = " Yanlış";
            Çöp.dytext.color = Çöp.yanlışrenk;
            Çöp.sayac += 1;
            if(Çöp.sayac == 7) {
                Çöp.sürehızı *= 0.4f;
                Çöp.sayac = 0;
            }
        }
    }

    private void OnMouseDown() {
        if(Çöp.enable == true) {
            copbas();
        }
    }
}