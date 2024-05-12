using System.Reflection;

namespace app;

public class Usuario
{
	private int id;
	public int Id
	{
		get
		{
			if(id.GetType() != typeof(int)) id = 0;
			return id;
		}
		set
		{
			if(value.GetType() == typeof(int)) id = value;
		}
	}

	private string nombre;
	public string Nombre
	{
		get
		{
			if(string.IsNullOrEmpty(nombre)) nombre = "sin Nombre";
			return nombre;
		}
		set
		{
			if(!string.IsNullOrEmpty(value)) nombre = value;
		}
	}
	
	private string apellido;
	public string Apellido
	{
		get
		{
			if(string.IsNullOrEmpty(apellido)) apellido = "sin Apellido";
			return apellido;
		}
		set
		{
			if(!string.IsNullOrEmpty(value)) apellido = value;
		}
	}
	public Usuario()
	{
		this.id = 0;
		this.nombre = string.Empty;
		this.apellido = string.Empty;
		Console.WriteLine("Se inicializa el constructor del usuario por defecto");
	}

	public override string ToString()
	{
		string returnedValue = string.Empty;

		foreach(PropertyInfo propertyInfo in this.GetType().GetProperties())
		{
			returnedValue += string.Format("El {0} es: {1}\n", propertyInfo.Name, propertyInfo.GetValue(this));
		}
		return returnedValue;
	}
}
