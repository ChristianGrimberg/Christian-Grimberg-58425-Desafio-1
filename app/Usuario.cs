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
			else id = 0;
		}
	}

	private string? nombre;
	public string? Nombre
	{
		get
		{
			if(string.IsNullOrEmpty(nombre)) nombre = "sin Nombre";
			return nombre;
		}
		set
		{
			if(!string.IsNullOrEmpty(value)) nombre = value;
			else nombre = string.Empty;
		}
	}
	
	private string? apellido;
	public string? Apellido
	{
		get
		{
			if(string.IsNullOrEmpty(apellido)) apellido = "sin Apellido";
			return apellido;
		}
		set
		{
			if(!string.IsNullOrEmpty(value)) apellido = value;
			else apellido = string.Empty;
		}
	}

	private string? nombreUsuario;
	public string? NombreUsuario
	{
		get
		{
			if(string.IsNullOrEmpty(nombreUsuario)) nombreUsuario = "sin NombreUsuario";
			return nombreUsuario;
		}
		set
		{
			if(!string.IsNullOrEmpty(value)) nombreUsuario = value;
			else nombreUsuario = string.Empty;
		}
	}

	private string? contraseña;
	public string? Contraseña
	{
		get
		{
			if(string.IsNullOrEmpty(contraseña)) contraseña = "sin Contraseña";
			return contraseña;
		}
		set
		{
			if(!string.IsNullOrEmpty(value)) contraseña = value;
			else contraseña = string.Empty;
		}
	}
	
	private string? mail;
	public string? Mail
	{
		get
		{
			if(string.IsNullOrEmpty(mail)) mail = "sin Mail";
			return mail;
		}
		set
		{
			if(!string.IsNullOrEmpty(value)) mail = value;
			else mail = string.Empty;
		}
	}
	

	public Usuario()
	{
		this.id = 0;
		this.nombre = string.Empty;
		this.apellido = string.Empty;
		this.nombreUsuario = string.Empty;
		this.contraseña = string.Empty;
		this.mail = string.Empty;
	}

	public Usuario(int _id, string _nombre, string _apellido, string _nombreUsuario, string _contraseña, string _mail)
	{
		this.Id = _id;
		this.Nombre = _nombre;
		this.Apellido = _apellido;
		this.NombreUsuario = _nombreUsuario;
		this.Contraseña = _contraseña;
		this.Mail = _mail;
	}

	public override string ToString()
	{
		string returnedValue = string.Empty;

		foreach(PropertyInfo propertyInfo in this.GetType().GetProperties())
		{
			returnedValue += string.Format("El {0} de Usuario es: {1}\n", propertyInfo.Name, propertyInfo.GetValue(this));
		}
		return returnedValue;
	}
}
