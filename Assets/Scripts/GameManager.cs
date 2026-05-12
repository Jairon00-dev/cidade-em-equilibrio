using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float dinheiro = 1000f;
    public float felicidade = 50f;
    public int populacao = 1000;
     public Slider happyBar;

    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI HappyText;
    public TextMeshProUGUI InforText;
    public TextMeshProUGUI PopulationText;

    void Start()
    {
        AtualizarUI();
    }

    public void InvestirSaude()
    {
        if (dinheiro >= 200)
        {
            dinheiro -= 200;
            felicidade += 10;
            InforText.text = "A saúde da cidade melhorou!";
        }

        AtualizarUI();
    }

    public void InvestirEducacao()
    {
        if (dinheiro >= 300)
        {
            dinheiro -= 300;
            felicidade += 15;
            InforText.text = "A educação da cidade evoluiu!";
        }

        AtualizarUI();
    }

    public void InvestirSeguranca()
    {
        if (dinheiro >= 250)
        {
            dinheiro -= 250;
            felicidade += 12;
            InforText.text = "A segurança aumentou!";
        }

        AtualizarUI();
    }

    void AtualizarUI()
    {
        moneyText.text = "Dinheiro: R$ " + dinheiro;
        HappyText.text = "Felicidade: " + felicidade + "%";
        PopulationText.text = "População: " + populacao;
        happyBar.value = felicidade;
    }
}