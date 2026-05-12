using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float dinheiro = 1000f;
    public float felicidade = 50f;
    public int populacao = 1000;
     public Slider happyBar;
     public GameObject gameOverPanel;

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

        populacao += 20;

        InforText.text = "A saúde da cidade melhorou!";
    }
    else
    {
        felicidade -= 5;

        populacao -= 10;

        InforText.text = "Crise na saúde pública!";
    }

    VerificarLimites();

    VerificarGameOver();

    AtualizarUI();
}

    public void InvestirEducacao()
{
    if (dinheiro >= 300)
    {
        dinheiro -= 300;

        felicidade += 15;

        populacao += 30;

        InforText.text = "A educação da cidade evoluiu!";
    }
    else
    {
        felicidade -= 7;

        populacao -= 15;

        InforText.text = "A educação entrou em crise!";
    }

    VerificarLimites();

    VerificarGameOver();

    AtualizarUI();
}

public void CobrarImpostos()
{
    dinheiro += 300;

    felicidade -= 5;

    InforText.text = "Os impostos foram arrecadados.";

    VerificarLimites();

    VerificarGameOver();

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
    else
    {
        felicidade -= 10;

        populacao -= 20;

        InforText.text = "A violência aumentou!";
    }

    VerificarLimites();

    VerificarGameOver();

    AtualizarUI();
}

void VerificarGameOver()
{
    if (felicidade <= 0 || populacao <= 0)
    {
        gameOverPanel.SetActive(true);

        Time.timeScale = 0;
    }
}
  void VerificarLimites()
    {
        if (felicidade > 100)
        {
            felicidade = 100;
        }

        if (felicidade < 0)
        {
            felicidade = 0;
        }

        if (populacao < 0)
        {
            populacao = 0;
        }
    }

    void AtualizarUI()
    {
        moneyText.text = "Dinheiro: R$ " + dinheiro;
        HappyText.text = "Felicidade: " + felicidade + "%";
        PopulationText.text = "População: " + populacao;
        happyBar.value = felicidade;
        
    
    }


     public void ReiniciarJogo()
    {
    Time.timeScale = 1;

    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}