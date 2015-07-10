using System;

namespace Free.Database.Dao.Net
{
	public class Container
	{
		internal DAO.Container con;

		public Container(DAO.Container _con)
		{
			con=_con;
		}

		public Permission AllPermissions
		{
			get { return (Permission)con.AllPermissions; }
		}

		public Documents Documents
		{
			get { return new Documents(con.Documents); }
		}

		public bool Inherit
		{
			get { return con.Inherit; }
			set { con.Inherit=value; }
		}

		public string Name
		{
			get { return con.Name; }
		}

		public string Owner
		{
			get { return con.Owner; }
			set { con.Owner=value; }
		}

		public Permission Permissions
		{
			get { return (Permission)con.Permissions; }
			set { con.Permissions=(int)value; }
		}

		public Properties Properties
		{
			get { return new Properties(con.Properties); }
		}

		public string UserName
		{
			get { return con.UserName; }
			set { con.UserName=value; }
		}
	}

	class ContainersEnumerator : System.Collections.IEnumerator
	{
		internal System.Collections.IEnumerator Enmtr;
		public ContainersEnumerator(System.Collections.IEnumerator _Enmtr) { Enmtr=_Enmtr; }
		public void Reset() { Enmtr.Reset(); }
		public bool MoveNext() { return Enmtr.MoveNext(); }
		public object Current { get{ return new Container((DAO.Container)Enmtr.Current); } }
	}

	public class Containers
	{
		internal DAO.Containers cons;

		public Containers(DAO.Containers _cons)
		{
			cons=_cons;
		}

		public short Count
		{
			get { return cons.Count; }
		}

		public System.Collections.IEnumerator GetEnumerator()
		{
			return new ContainersEnumerator(cons.GetEnumerator());
		}

		public void Refresh()
		{
			cons.Refresh();
		}

		public Container this[string index] 
		{
			get { return new Container(cons[index]); }
		}

		public Container this[int index] 
		{
			get { return new Container(cons[index]); }
		}
	}
}
