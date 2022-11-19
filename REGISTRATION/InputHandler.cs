using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour {
    [SerializeField] InputField nameInput;
    [SerializeField] InputField ageInput;
    [SerializeField] InputField idInput;
    [SerializeField] string filename;

    List<InputEntry> entries = new List<InputEntry> ();

    private void Start () {
        entries = FileHandler.ReadListFromJSON<InputEntry> (filename);
    }

    public void AddNameToList () {
        entries.Add (new InputEntry (nameInput.text, ageInput.text ,idInput.text));
        nameInput.text = "";
        ageInput.text = "";
       idInput.text = "";


        FileHandler.SaveToJSON<InputEntry> (entries, filename);
    }
}