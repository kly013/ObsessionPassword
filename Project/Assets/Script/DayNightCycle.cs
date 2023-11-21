using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayNightCycle : MonoBehaviour
{
    [Header("Time")]
    [Tooltip("Day Length in Minutes")]
    [SerializeField]
    private float _targetDayLength = 13f;//Length of day in minutes
    public float targetDayLength
    {
        get
        {
            return _targetDayLength;
        }
    }

    [SerializeField]
    private float elapsedTime;
    [SerializeField]
    private Text clockText;

    [SerializeField]
    [Range(0f,1f)]
    private float _timeofDay;
    public float timeofDay
    {
        get
        {
            return _timeofDay;
        }
    }

    [SerializeField]
    private int _dayNumber = 0;//tracks the days passed
    public int dayNumber
    {
        get
        {
            return _dayNumber;
        }
    }

    [SerializeField]
    private int _yearNumber;
    public int yearNumber
    {
        get
        {
            return _yearNumber;
        }
    }
    private float _timeScale = 100f;

    [SerializeField]
    private int _yearLength = 100;
    public float yearLength
    {
        get
        {
            return _yearLength;
        }
    }
    public bool pause = false;

    [Header("Sun Light")]
    [SerializeField]
    private Transform dailyRotation;
    [SerializeField]
    private Light sun;
    private float intensity;
    [SerializeField]
    private float sunBaseIntensity = 1f;
    [SerializeField]
    private float sunVariation = 1.5f;
    [SerializeField]
    private Gradient sunColor;

    [Header("Seasonal Variables")]
    [SerializeField]
    private Transform sunSeasonalRotation;
    [SerializeField]
    [Range(-45f, 45f)]
    private float maxSeasonalTilt;

    [Header("Modules")]
    private List<DN_ModelBase> moduleList = new List<DN_ModelBase>();

    private void Start()
    {

    }

    private void Update()
    {
        if (!pause)
        {
            UpdateTimeScale();
            UpdateTime();
            UpdateClock();
        }

        AdjustSunRotation();
        SunIntesity();
        UpdateModules();//will update modules each fram
    }
    private void UpdateTimeScale()
    {
        _timeScale = 24 / (_targetDayLength / 60);
    }

    private void UpdateTime()
    {
        _timeofDay += Time.deltaTime * _timeScale / 86400;//second in a day
        elapsedTime = timeofDay * _targetDayLength * 60;
        if (_timeofDay > 1)//New day
        {
            elapsedTime = 0;
            _dayNumber++;
            _timeofDay -= 1;
        }
        if (_dayNumber > _yearLength)//New year
        {
            _yearNumber++;
            _dayNumber = 0;
        }
    }

    private void UpdateClock()
    {
        float time = elapsedTime / (targetDayLength * 60);
        float hour = Mathf.FloorToInt(time * 24);
        float minute = Mathf.FloorToInt(((time * 24) - hour) * 60);

        string hourString;
        string minuteString;

        if (hour < 10)
        {
            hourString = "0" + hour.ToString();
        }
        else
        {
            hourString = hour.ToString();
        }

        if (minute < 10)
        {
            minuteString = "0" + minute.ToString();

        }
        else
        {
            minuteString = minute.ToString();
        }
        clockText.text = hour.ToString() + ":" + minute.ToString();
        
    }

    //rotates the sun daily(and seasonally soon too)
    private void AdjustSunRotation()
    {
        float sunAngle = timeofDay * 360f;
        dailyRotation.transform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, sunAngle));

        float seasonalAngle = -maxSeasonalTilt * Mathf.Cos(dayNumber / _yearLength * 2f * Mathf.PI);
        sunSeasonalRotation.localRotation = Quaternion.Euler(new Vector3(seasonalAngle, 0f, 0f));
    }

    private void SunIntesity()
    {
        intensity = Vector3.Dot(sun.transform.forward, Vector3.down);
        intensity = Mathf.Clamp01(intensity);

        sun.intensity = intensity*sunVariation+sunBaseIntensity;
    }

    private void AdjustSunColor()
    {
        sun.color = sunColor.Evaluate(intensity);
    }

    public void AddModule(DN_ModelBase module)
    {
        moduleList.Add(module);
    }

    public void RemoveModule(DN_ModelBase module)
    {
        moduleList.Remove(module);
    }

    //update each module based on current sun intensity
    private void UpdateModules()
    {
        foreach(DN_ModelBase module in moduleList)
        {
            module.UpdateModule(intensity);
        }
    }
}
