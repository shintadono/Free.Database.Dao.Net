using System;

namespace Free.Database.Dao.Net
{
	public class Property
	{
		internal DAO.Property prop;

		public Property(DAO.Property _prop)
		{
			prop=_prop;
		}

		public bool Inherited
		{
			get { return prop.Inherited; }
		}

		public string Name
		{
			get { return prop.Name; }
			set { prop.Name=value; }
		}

		public DataType Type
		{
			get { return (DataType)prop.Type; }
			set { prop.Type=(short)value; }
		}

		public object Value
		{
			get { return prop.Value; }
			set { prop.Value=value; }
		}
	}

	class PropertiesEnumerator : System.Collections.IEnumerator
	{
		internal System.Collections.IEnumerator Enmtr;
		public PropertiesEnumerator(System.Collections.IEnumerator _Enmtr) { Enmtr=_Enmtr; }
		public void Reset() { Enmtr.Reset(); }
		public bool MoveNext() { return Enmtr.MoveNext(); }
		public object Current { get{ return new Property((DAO.Property)Enmtr.Current); } }
	}

	public class Properties
	{
		internal DAO.Properties props;

		public Properties(DAO.Properties _props) 
		{
			props=_props;
		}

		public short Count 
		{
			get { return props.Count; }
		}

		public System.Collections.IEnumerator GetEnumerator()
		{
			return new PropertiesEnumerator(props.GetEnumerator());
		}
		
		public void Refresh()
		{
			props.Refresh();
		}
		
		public void Append(Property prop)
		{
			props.Append(prop.prop);
		}
		
		public void Delete(string name)
		{
			props.Delete(name);
		}
		
		public Property this[string index]
		{
			get { return new Property(props[index]); }
		}

		public Property this[int index]
		{
			get { return new Property(props[index]); }
		}
	}
}
