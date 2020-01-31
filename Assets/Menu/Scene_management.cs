using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_management : MonoBehaviour
{
    private AudioSource click;

    public void Start(){
        click = GameObject.Find("Click").GetComponent<AudioSource>();
    }

    public void pilih_game()
    {
        click.Play();
        SceneManager.LoadScene("Menu/Pilih_game");
    }

    public void pilihmateri(){
        click.Play();
        SceneManager.LoadScene("Materi/pilihMateri");
    }

    public void materiCuaca(){
        click.Play();
        SceneManager.LoadScene("Materi/Cuaca/Materi cuaca");
    }

    public void materiIklim(){
        click.Play();
        SceneManager.LoadScene("Materi/Iklim/Materi iklim");
    }

    public void level_tebak_gambar(){
        click.Play();
        SceneManager.LoadScene("Tebak gambar/Level_tebak_gambar");
    }

    public void level_tropis(){
        click.Play();
        SceneManager.LoadScene("Puzzle game/Level_tropis");
    }

    public void level_Sub_tropis(){
        click.Play();
        SceneManager.LoadScene("Puzzle game/Level_Sub_tropis");
    }

    public void level_Sedang(){
        click.Play();
        SceneManager.LoadScene("Puzzle game/Level_Sedang");
    }

    public void level_Dingin(){
        click.Play();
        SceneManager.LoadScene("Puzzle game/Level_Dingin");
    }

    public void jenis_musim(){
        click.Play();
        SceneManager.LoadScene("Puzzle game/Jenis musim");
    }
    
    public void tebak_gambar(){
        click.Play();
        string nama = gameObject.name.Substring(6);
        SceneManager.LoadScene("Tebak gambar/Level_" + nama);
    }

    public void puzzle_game(){
        click.Play();
        string nama = gameObject.name.Substring(6);
        SceneManager.LoadScene("Puzzle game/Level_" + nama);
    }

    public void next_scene(){
        click.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void main_menu()
    {
        click.Play();
        SceneManager.LoadScene( "Menu/Menu");
    }

    public void petunjuk_kuis(){
        click.Play();
        SceneManager.LoadScene("Kuis/Petunjuk");
    }

    public void kuis(){
        click.Play();
        SceneManager.LoadScene("Kuis/Main");
        kuisController.buatList();
    }

    public void tentang(){
        click.Play();
        SceneManager.LoadScene("Tentang/Tentang");
    }

    public static void unlockNextlevel()
    {
        int nama = int.Parse(SceneManager.GetActiveScene().name.Substring(6));
        int unlock = PlayerPrefs.GetInt("unlockTebakgambar", 1);
        int ternary = ((nama + 1) < unlock ? unlock : (nama + 1));
        PlayerPrefs.SetInt("unlockTebakgambar", ternary);
    }

    public static void unlockNextlevel_Puzzle(){
        int nama = int.Parse(SceneManager.GetActiveScene().name.Substring(6));
        int unlock = PlayerPrefs.GetInt("unlockPuzzlegame", 1);
        int ternary = ((nama + 1) < unlock ? unlock : (nama + 1));
        PlayerPrefs.SetInt("unlockPuzzlegame", ternary);
    }

    public void restart()
    {
        click.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    public void quitgame()
    {
        click.Play();
        Debug.Log("Quit!");
        Application.Quit();
    }

    public void tutorial_puzzle(){
        click.Play();
        SceneManager.LoadScene("Puzzle game/tutorial_puzzle");        
    }

    public void tutorial_tg(){
        click.Play();
        SceneManager.LoadScene("Tebak gambar/tutorial_tebak_gambar");
    }

}
