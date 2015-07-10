using System;

namespace Free.Database.Dao.Net
{
	public class User
	{
		internal DAO.User usr;

		public User(DAO.User _usr)
		{
			usr=_usr;
		}

		public Group CreateGroup()
		{
			return new Group(usr.CreateGroup(Type.Missing, Type.Missing));
		}

		public Group CreateGroup(string name)
		{
			return new Group(usr.CreateGroup(name, Type.Missing));
		}

		public Group CreateGroup(string name, string pid)
		{
			return new Group(usr.CreateGroup(name, pid));
		}

		public void NewPassword(string oldpwd, string newpwd)
		{
			usr.NewPassword(oldpwd, newpwd);
		}

		public Groups Groups
		{
			get { return new Groups(usr.Groups); }
		}

		public string Name
		{
			get { return usr.Name; }
			set { usr.Name=value; }
		}

		public string Password
		{
			set { usr.Password=value; }
		}

		public string PID
		{
			set { usr.PID=value; }
		}

		public Properties Properties
		{
			get { return new Properties(usr.Properties); }
		}
	}

	class UsersEnumerator : System.Collections.IEnumerator
	{
		internal System.Collections.IEnumerator Enmtr;
		public UsersEnumerator(System.Collections.IEnumerator _Enmtr) { Enmtr=_Enmtr; }
		public void Reset() { Enmtr.Reset(); }
		public bool MoveNext() { return Enmtr.MoveNext(); }
		public object Current { get{ return new User((DAO.User)Enmtr.Current); } }
	}

	public class Users
	{
		internal DAO.Users usrs;

		public Users(DAO.Users _usrs) 
		{
			usrs=_usrs;
		}

		public short Count 
		{
			get { return usrs.Count; }
		}

		public System.Collections.IEnumerator GetEnumerator()
		{
			return new UsersEnumerator(usrs.GetEnumerator());
		}

		public void Refresh()
		{
			usrs.Refresh();
		}

		public void Append(User usr)
		{
			usrs.Append(usr.usr);
		}

		public void Delete(string name)
		{
			usrs.Delete(name);
		}

		public User this[string index]
		{
			get { return new User(usrs[index]); }
		}

		public User this[int index]
		{
			get { return new User(usrs[index]); }
		}
	}
}
