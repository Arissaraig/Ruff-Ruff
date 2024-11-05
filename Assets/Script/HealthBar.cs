using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private float _maxHealth = 100;
    private float _currentHealth;
    [SerializeField] private Image _HealthBarFill;
    public GameObject GameOver;
    public GameObject Passed;


    void Start()
    {
        _currentHealth = 5; 
        GameOver.SetActive(false);
        Passed.SetActive(false);
    }

    public void UpdateHealth(float amount)
    {
        _currentHealth += amount;

        
        _currentHealth = Mathf.Clamp(_currentHealth, 0, _maxHealth);

        UpdateHealthBar();

        if (_currentHealth <= 0)
        {
            GameOver.SetActive(true); 
        }
        else if (_currentHealth == 100)
        {
            Passed.SetActive(true); 
        }
    }

    private void UpdateHealthBar()
    {
        float targetFillAmount = _currentHealth / _maxHealth;
        _HealthBarFill.fillAmount = targetFillAmount;
    }
}
