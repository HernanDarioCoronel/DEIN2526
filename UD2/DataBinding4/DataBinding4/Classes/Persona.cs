using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Persona : INotifyPropertyChanged
{
    private string _nombre;
    private int _edad;
    private bool _estudiante;

    public string Nombre
    {
        get => _nombre;
        set { _nombre = value; OnPropertyChanged(); }
    }

    public int Edad
    {
        get => _edad;
        set { _edad = value; OnPropertyChanged(); }
    }

    public bool Estudiante
    {
        get => _estudiante;
        set { _estudiante = value; OnPropertyChanged(); }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}