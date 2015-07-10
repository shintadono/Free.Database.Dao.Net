using System;

namespace Free.Database.Dao.Net
{
	public class Group
	{
		internal DAO.Group gr;

		public Group(DAO.Group _gr)
		{
			gr=_gr;
		}

		public User CreateUser()
		{
			return new User(gr.CreateUser(Type.Missing, Type.Missing, Type.Missing));
		}

		public User CreateUser(string name)
		{
			return new User(gr.CreateUser(name, Type.Missing, Type.Missing));
		}

		public User CreateUser(string name, string pid)
		{
			return new User(gr.CreateUser(name, pid, Type.Missing));
		}

		public User CreateUser(string name, string pid, string password)
		{
			return new User(gr.CreateUser(name, pid, password));
		}

		public string Name
		{
			get { return gr.Name; }
			set { gr.Name=value; }
		}

		public string PID
		{
			set { gr.PID=value; }
		}

		public Properties Properties
		{
			get { return new Properties(gr.Properties); }
		}

		public Users Users
		{
			get { return new Users(gr.Users); }
		}
	}

	class GroupsEnumerator : System.Collections.IEnumerator
	{
		internal System.Collections.IEnumerator Enmtr;
		public GroupsEnumerator(System.Collections.IEnumerator _Enmtr) { Enmtr=_Enmtr; }
		public void Reset() { Enmtr.Reset(); }
		public bool MoveNext() { return Enmtr.MoveNext(); }
		public object Current { get{ return new Group((DAO.Group)Enmtr.Current); } }
	}

	public class Groups
	{
		internal DAO.Groups grs;

		public Groups(DAO.Groups _grs) 
		{
			grs=_grs;
		}

		public short Count 
		{
			get { return grs.Count; }
		}

		public System.Collections.IEnumerator GetEnumerator()
		{
			return new GroupsEnumerator(grs.GetEnumerator());
		}
		
		public void Refresh()
		{
			grs.Refresh();
		}
		
		public void Append(Group gr)
		{
			grs.Append(gr.gr);
		}
		
		public void Delete(string name)
		{
			grs.Delete(name);
		}
		
		public Group this[string index]
		{
			get { return new Group(grs[index]); }
		}

		public Group this[int index]
		{
			get { return new Group(grs[index]); }
		}
	}
}
