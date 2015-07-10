using System;

namespace Free.Database.Dao.Net
{
	public class DBEngine
	{
		internal DAO.DBEngineClass dbe;

		public DBEngine()
		{
			dbe=new DAO.DBEngineClass();
		}

		[Obsolete("Use CreateWorkspace instead.", false)]
		public Workspace _30_CreateWorkspace(string name, string user, string password)
		{
			return new Workspace(dbe._30_CreateWorkspace(name, user, password));
		}

		public void BeginTrans()
		{
			dbe.BeginTrans();
		}

		public void CommitTrans()
		{
			dbe.CommitTrans(0);
		}

		public void CommitTrans(CommitTransOptions option)
		{
			dbe.CommitTrans((int)option);
		}

		public void CompactDatabase(string olddb, string newdb)
		{
			dbe.CompactDatabase(olddb, newdb, Type.Missing, Type.Missing, Type.Missing);
		}

		public void CompactDatabase(string olddb, string newdb, string locale)
		{
			dbe.CompactDatabase(olddb, newdb, locale, Type.Missing, Type.Missing);
		}

		public void CompactDatabase(string olddb, string newdb, string locale,
			DatabaseType options)
		{
			dbe.CompactDatabase(olddb, newdb, locale, options, Type.Missing);
		}

		public void CompactDatabase(string olddb, string newdb, string locale,
			DatabaseType options, string password)
		{
			dbe.CompactDatabase(olddb, newdb, locale, options, password);
		}

		public Database CreateDatabase(string name, string locale)
		{
			return new Database(dbe.CreateDatabase(name, locale, Type.Missing));
		}

		public Database CreateDatabase(string name, string locale, DatabaseType options)
		{
			return new Database(dbe.CreateDatabase(name, locale, options));
		}

		public Workspace CreateWorkspace(string name, string user, string password)
		{
			return new Workspace(dbe.CreateWorkspace(name, user, password, Type.Missing));
		}

		public Workspace CreateWorkspace(string name, string user, string password, WorkspaceType type)
		{
			return new Workspace(dbe.CreateWorkspace(name, user, password, type));
		}

		public void FreeLocks()
		{
			dbe.FreeLocks();
		}

		public void Idle()
		{
			dbe.Idle(Type.Missing);
		}

		public void Idle(Idle action)
		{
			dbe.Idle(action);
		}

		public int ISAMStats(int statnum)
		{
			return dbe.ISAMStats(statnum, Type.Missing);
		}

		public int ISAMStats(int statnum, bool reset)
		{
			return dbe.ISAMStats(statnum, reset);
		}

		public Connection OpenConnection(string name)
		{
			return new Connection(dbe.OpenConnection(name, Type.Missing, Type.Missing, Type.Missing));
		}

		public Connection OpenConnection(string name, DriverPrompt options)
		{
			return new Connection(dbe.OpenConnection(name, options, Type.Missing, Type.Missing));
		}

		public Connection OpenConnection(string name, DriverPrompt options, bool readOnly)
		{
			return new Connection(dbe.OpenConnection(name, options, readOnly, Type.Missing));
		}

		public Connection OpenConnection(string name, DriverPrompt options, bool readOnly, string connect)
		{
			return new Connection(dbe.OpenConnection(name, options, readOnly, connect));
		}

		public Database OpenDatabase(string dbname)
		{
			return new Database(dbe.OpenDatabase(dbname, Type.Missing, Type.Missing, Type.Missing));
		}

		public Database OpenDatabase(string dbname, DriverPrompt options)
		{
			return new Database(dbe.OpenDatabase(dbname, options, Type.Missing, Type.Missing));
		}

		public Database OpenDatabase(string dbname, bool options)
		{
			return new Database(dbe.OpenDatabase(dbname, options, Type.Missing, Type.Missing));
		}

		public Database OpenDatabase(string dbname, DriverPrompt options, bool readOnly)
		{
			return new Database(dbe.OpenDatabase(dbname, options, readOnly, Type.Missing));
		}

		public Database OpenDatabase(string dbname, bool options, bool readOnly)
		{
			return new Database(dbe.OpenDatabase(dbname, options, readOnly, Type.Missing));
		}

		public Database OpenDatabase(string dbname, DriverPrompt options, bool readOnly, string connect)
		{
			return new Database(dbe.OpenDatabase(dbname, options, readOnly, connect));
		}

		public Database OpenDatabase(string dbname, bool options, bool readOnly, string connect)
		{
			return new Database(dbe.OpenDatabase(dbname, options, readOnly, connect));
		}

		public void RegisterDatabase(string dbname, string driver, bool silent, string attributes)
		{
			dbe.RegisterDatabase(dbname, driver, silent, attributes);
		}

		public void RepairDatabase(string dbname)
		{
			dbe.RepairDatabase(dbname);
		}

		public void Rollback()
		{
			dbe.Rollback();
		}

		[Obsolete("Use DBEngine.IniPath instead.", false)]
		public void SetDataAccessOption(short option, object val)
		{
			dbe.SetDataAccessOption(option, val);
		}

		[Obsolete("Use DBEngine.DefaultUser and DBEngine.DefaultPassword instead.", false)]
		public void SetDefaultWorkspace(string name, string password)
		{
			dbe.SetDefaultWorkspace(name, password);
		}

		public void SetOption(SetOption option, int val)
		{
			dbe.SetOption((int)option, val);
		}

		public void SetOption(SetOption option, string val)
		{
			dbe.SetOption((int)option, val);
		}

		public string DefaultPassword
		{
			set { dbe.DefaultPassword=value; }
		}

		public WorkspaceType DefaultType
		{
			get { return (WorkspaceType)dbe.DefaultType; }
			set { dbe.DefaultType=(int)value; }
		}

		public string DefaultUser
		{
			set { dbe.DefaultUser=value; }
		}

		public Errors Errors
		{
			get { return new Errors(dbe.Errors); }
		}

		public string IniPath
		{
			get { return dbe.IniPath; }
			set { dbe.IniPath=value; }
		}

		public short LoginTimeout
		{
			get { return dbe.LoginTimeout; }
			set { dbe.LoginTimeout=value; }
		}

		public Properties Properties
		{
			get { return new Properties(dbe.Properties); }
		}

		public string SystemDB
		{
			get { return dbe.SystemDB; }
			set { dbe.SystemDB=value; }
		}

		public string Version
		{
			get { return dbe.Version; }
		}

		public Workspaces Workspaces
		{
			get { return new Workspaces(dbe.Workspaces); }
		}
	}
}
