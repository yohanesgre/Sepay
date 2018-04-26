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
            new ArrayList() {    "Prasasti Mulawarman",   "Prasasti Mulawarman, atau disebut juga Prasasti Kutai, adalah sebuah prasasti yang merupakan peninggalan dari Kerajaan Kutai. Isinya menceritakan Raja Mulawarman yang memberikan sumbangan kepada para kaum Brahmana berupa sapi yang banyak. Mulawarman disebutkan sebagai cucu dari Kudungga, dan anak dari Aswawarman. Prasasti ini merupakan bukti peninggalan tertua dari kerajaan yang beragama Hindu di Indonesia. Nama Kutai umumnya digunakan sebagai nama kerajaan ini meskipun tidak disebutkan dalam prasasti, sebab prasasti ditemukan di Kabupaten Kutai, Kalimantan Timur, tepatnya di hulu Sungai Mahakam."},
            new ArrayList() {    "Prasasti Mulawarman",   "Prasasti Mulawarman, atau disebut juga Prasasti Kutai, adalah sebuah prasasti yang merupakan peninggalan dari Kerajaan Kutai. Terdapat tujuh buah yupa yang memuat prasasti, namun baru 4 yang berhasil dibaca dan diterjemahkan. Prasasti ini menggunakan huruf Pallawa Pra-Nagari dan dalam bahasa Sanskerta, yang diperkirakan dari bentuk dan jenisnya berasal dari sekitar 400 Masehi. Prasasti ini ditulis dalam bentuk puisi anustub."}

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
