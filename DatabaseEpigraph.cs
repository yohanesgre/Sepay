using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseEpigraph : MonoBehaviour {

    // Use this for initialization
    private static DatabaseEpigraph databaseEpigraph = new DatabaseEpigraph();
    public DatabaseEpigraph()
    {
        loadDatabase();
    }

    public static DatabaseEpigraph getInstance()
    {
        return databaseEpigraph;
    }

    private List<ArrayList> arrayOfEpigraph;

    private void loadDatabase()
    {
        arrayOfEpigraph = new List<ArrayList>()
        {
            new ArrayList() {                   "Name",   "Description" },
            new ArrayList() {    "Prasasti Singhasari",   "Prasasti Singhasari, yang bertarikh tahun 1351 M, ditemukan di Singosari, Kabupaten Malang, Jawa Timur dan sekarang disimpan di Museum Gajah. Ditulis dengan Aksara Jawa. Prasasti ini ditulis untuk mengenang pembangunan sebuah caitya atau candi pemakaman yang dilaksanakan oleh Mahapatih Gajah Mada."},
            new ArrayList() {    "Prasasti Mulawarman",   "Prasasti Mulawarman, atau disebut juga Prasasti Kutai, adalah sebuah prasasti yang merupakan peninggalan dari Kerajaan Kutai. Isinya menceritakan Raja Mulawarman yang memberikan sumbangan kepada para kaum Brahmana berupa sapi yang banyak. Mulawarman disebutkan sebagai cucu dari Kudungga, dan anak dari Aswawarman. Prasasti ini merupakan bukti peninggalan tertua dari kerajaan yang beragama Hindu di Indonesia. Nama Kutai umumnya digunakan sebagai nama kerajaan ini meskipun tidak disebutkan dalam prasasti, sebab prasasti ditemukan di Kabupaten Kutai, Kalimantan Timur, tepatnya di hulu Sungai Mahakam."}
        };
    }

    public string getEpigraphName(int _id)
    {
        return (string)arrayOfEpigraph[_id][0];
    }

    public string getEpigraphDescription(int _id)
    {
        return (string)arrayOfEpigraph[_id][1];
    }
}
