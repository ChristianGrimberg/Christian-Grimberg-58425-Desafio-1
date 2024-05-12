using System.Reflection;

namespace app;

public class Producto
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

	public override string ToString()
	{
		string returnedValue = string.Empty;

		foreach(PropertyInfo propertyInfo in this.GetType().GetProperties())
		{
			returnedValue += string.Format("{0} de {1} es: {2}\n", propertyInfo.Name, this.GetType().Name ,propertyInfo.GetValue(this));
		}
		return returnedValue;
	}
}
