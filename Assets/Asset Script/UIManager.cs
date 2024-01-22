using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public GameObject Mainmenublur;
    public RectTransform MenuAtas, MenuKanan, MenuKiri, PanelButton, PanelLesson, PanelInformasi, PanelGuide;
    public RectTransform PanelQuixBack, PanelSoal1, PanelSoal2, PanelSoal3, PanelSoal4, PanelSoal5, PanelSoal6, PanelSoal7, PanelSoal8, PanelSoal9, PanelSoal10, PanelNilai;


    // Start is called before the first frame update
    void Start()
    {
        Mainmenublur.SetActive(false);
        MenuAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelInformasi.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void ButtonKembali()
    {
        Mainmenublur.SetActive(false);
        MenuAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelInformasi.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void MenuLesson()
    {
        Mainmenublur.SetActive(true);
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelInformasi.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void MenuInformasi()
    {
        Mainmenublur.SetActive(true);
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelInformasi.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void MenuGuide()
    {
        Mainmenublur.SetActive(true);
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelInformasi.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal1()
    {
        Mainmenublur.SetActive(true);
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelInformasi.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal2()
    {
        Mainmenublur.SetActive(true);
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelInformasi.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal3()
    {
        Mainmenublur.SetActive(true);
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelInformasi.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal4()
    {
        Mainmenublur.SetActive(true);
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelInformasi.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal5()
    {
        Mainmenublur.SetActive(true);
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelInformasi.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal6()
    {
        Mainmenublur.SetActive(true);
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelInformasi.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal7()
    {
        Mainmenublur.SetActive(true);
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelInformasi.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal8()
    {
        Mainmenublur.SetActive(true);
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelInformasi.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal9()
    {
        Mainmenublur.SetActive(true);
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelInformasi.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal10()
    {
        Mainmenublur.SetActive(true);
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelInformasi.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void NilaiSoal()
    {
        Mainmenublur.SetActive(true);
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelInformasi.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
}