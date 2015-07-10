using System;

namespace Free.Database.Dao.Net
{
	public class Workspace
	{
		internal DAO.Workspace wks;

		public Workspace(DAO.Workspace _wks)
		{
			wks=_wks;
		}

		public void BeginTrans()
		{
			wks.BeginTrans();
		}

		public void Close()
		{
			wks.Close();
		}

		public void CommitTrans()
		{
			wks.CommitTrans(0);
		}

		public void CommitTrans(CommitTransOptions option)
		{
			wks.CommitTrans((int)option);
		}

		public Database CreateDatabase(string name, string locale)
		{
			return new Database(wks.CreateDatabase(name, locale, System.Type.Missing));
		}

		public Database CreateDatabase(string name, string locale, DatabaseType options)
		{
			return new Database(wks.CreateDatabase(name, locale, options));
		}

		public Group CreateGroup()
		{
			return new Group(wks.CreateGroup(System.Type.Missing, System.Type.Missing));
		}

		public Group CreateGroup(string name)
		{
			return new Group(wks.CreateGroup(name, System.Type.Missing));
		}

		public Group CreateGroup(string name, string pid)
		{
			return new Group(wks.CreateGroup(name, pid));
		}

		public User CreateUser()
		{
			return new User(wks.CreateUser(System.Type.Missing, System.Type.Missing, System.Type.Missing));
		}

		public User CreateUser(string name)
		{
			return new User(wks.CreateUser(name, System.Type.Missing, System.Type.Missing));
		}

		public User CreateUser(string name, string pid)
		{
			return new User(wks.CreateUser(name, pid, System.Type.Missing));
		}

		public User CreateUser(string name, string pid, string password)
		{
			return new User(wks.CreateUser(name, pid, password));
		}

		public Connection OpenConnection(string name)
		{
			return new Connection(wks.OpenConnection(name, System.Type.Missing, System.Type.Missing, System.Type.Missing));
		}

		public Connection OpenConnection(string name, DriverPrompt options)
		{
			return new Connection(wks.OpenConnection(name, options, System.Type.Missing, System.Type.Missing));
		}

		public Connection OpenConnection(string name, DriverPrompt options, bool readOnly)
		{
			return new Connection(wks.OpenConnection(name, options, readOnly, System.Type.Missing));
		}

		public Connection OpenConnection(string name, DriverPrompt options, bool readOnly, string connect)
		{
			return new Connection(wks.OpenConnection(name, options, readOnly, connect));
		}

		public Database OpenDatabase(string dbname)
		{
			return new Database(wks.OpenDatabase(dbname, System.Type.Missing, System.Type.Missing, System.Type.Missing));
		}

		public Database OpenDatabase(string dbname, DriverPrompt options)
		{
			return new Database(wks.OpenDatabase(dbname, options, System.Type.Missing, System.Type.Missing));
		}

		public Database OpenDatabase(string dbname, DriverPrompt options, bool readOnly)
		{
			return new Database(wks.OpenDatabase(dbname, options, readOnly, System.Type.Missing));
		}

		public Database OpenDatabase(string dbname, DriverPrompt options, bool readOnly, string connect)
		{
			return new Database(wks.OpenDatabase(dbname, options, readOnly, connect));
		}

		public void Rollback()
		{
			wks.Rollback();
		}

		public string _30_Password
		{
			set { wks._30_Password=value; }
		}

		public string _30_UserName
		{
			set { wks._30_UserName=value; }
		}

		public Connections Connections
		{
			get { return new Connections(wks.Connections); }
		}

		public Databases Databases
		{
			get { return new Databases(wks.Databases); }
		}

		public CursorDriver DefaultCursorDriver
		{
			get { return (CursorDriver)wks.DefaultCursorDriver; }
			set { wks.DefaultCursorDriver=(int)value; }
		}

		public Groups Groups
		{
			get { return new Groups(wks.Groups); }
		}

		public int hEnv
		{
			get { return wks.hEnv; }
		}

		public bool IsolateODBCTrans
		{
			get { return wks.IsolateODBCTrans!=0; }
			set { wks.IsolateODBCTrans=(short)(value?1:0); }
		}

		public int LoginTimeout
		{
			get { return wks.LoginTimeout; }
			set { wks.LoginTimeout=value; }
		}

		public string Name
		{
			get { return wks.Name; }
			set { wks.Name=value; }
		}

		public Properties Properties
		{
			get { return new Properties(wks.Properties); }
		}

		public WorkspaceType Type
		{
			get { return (WorkspaceType)wks.Type; }
		}

		public string UserName
		{
			get { return wks.UserName; }
		}

		public Users Users
		{
			get { return new Users(wks.Users); }
		}
	}

	class WorkspacesEnumerator : System.Collections.IEnumerator
	{
		internal System.Collections.IEnumerator Enmtr;
		public WorkspacesEnumerator(System.Collections.IEnumerator _Enmtr) { Enmtr=_Enmtr; }
		public void Reset() { Enmtr.Reset(); }
		public bool MoveNext() { return Enmtr.MoveNext(); }
		public object Current { get{ return new Workspace((DAO.Workspace)Enmtr.Current); } }
	}

	public class Workspaces
	{
		internal DAO.Workspaces wkss;

		public Workspaces(DAO.Workspaces _wkss)
		{
			wkss=_wkss;
		}

		public short Count
		{
			get { return wkss.Count; }
		}

		public System.Collections.IEnumerator GetEnumerator()
		{
			return new WorkspacesEnumerator(wkss.GetEnumerator());
		}

		public void Refresh()
		{
			wkss.Refresh();
		}

		public void Append(Workspace wks)
		{
			wkss.Append(wks.wks);
		}

		public void Delete(string name)
		{
			wkss.Delete(name);
		}

		public Workspace this[string index]
		{
			get { return new Workspace(wkss[index]); }
		}

		public Workspace this[int index]
		{
			get { return new Workspace(wkss[index]); }
		}
	}
}
