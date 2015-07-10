using System;

namespace Free.Database.Dao.Net
{
	public class Database
	{
		internal DAO.Database db;

		public Database(DAO.Database _db)
		{
			db=_db;
		}

		[Obsolete("Use OpenRecordset instead.", false)]
		public Recordset _30_OpenRecordset(string source)
		{
			return new Recordset(db._30_OpenRecordset(source, Type.Missing, Type.Missing));
		}

		[Obsolete("Use OpenRecordset instead.", false)]
		public Recordset _30_OpenRecordset(string source, RecordsetType type)
		{
			return new Recordset(db._30_OpenRecordset(source, type, Type.Missing));
		}

		[Obsolete("Use OpenRecordset instead.", false)]
		public Recordset _30_OpenRecordset(string source, RecordsetType type, RecordsetOption options)
		{
			return new Recordset(db._30_OpenRecordset(source, type, options));
		}
		
		public void BeginTrans()
		{
			db.BeginTrans();
		}

		public void Close()
		{
			db.Close();
		}

		public void CommitTrans()
		{
			db.CommitTrans(0);
		}

		public void CommitTrans(CommitTransOptions option)
		{
			db.CommitTrans((int)option);
		}

		[Obsolete("Use OpenRecordset instead.", false)]
		public Recordset CreateDynaset(string source, RecordsetOption options, bool inconsistent)
		{
			return new Recordset(db.CreateDynaset(source, options, inconsistent));
		}

		public Property CreateProperty()
		{
			return new Property(db.CreateProperty(Type.Missing, Type.Missing, Type.Missing, Type.Missing));
		}

		public Property CreateProperty(string name)
		{
			return new Property(db.CreateProperty(name, Type.Missing, Type.Missing, Type.Missing));
		}

		public Property CreateProperty(string name, DataType type)
		{
			return new Property(db.CreateProperty(name, type, Type.Missing, Type.Missing));
		}

		public Property CreateProperty(string name, DataType type, object val)
		{
			return new Property(db.CreateProperty(name, type, val, Type.Missing));
		}

		public Property CreateProperty(string name, DataType type, object val, bool ddl)
		{
			return new Property(db.CreateProperty(name, type, val, ddl));
		}

		public QueryDef CreateQueryDef()
		{
			return new QueryDef(db.CreateQueryDef(Type.Missing, Type.Missing));
		}

		public QueryDef CreateQueryDef(string name)
		{
			return new QueryDef(db.CreateQueryDef(name, Type.Missing));
		}

		public QueryDef CreateQueryDef(string name, string sqltext)
		{
			return new QueryDef(db.CreateQueryDef(name, sqltext));
		}

		public Relation CreateRelation()
		{
			return new Relation(db.CreateRelation(Type.Missing, Type.Missing, Type.Missing, Type.Missing));
		}

		public Relation CreateRelation(string name)
		{
			return new Relation(db.CreateRelation(name, Type.Missing, Type.Missing, Type.Missing));
		}

		public Relation CreateRelation(string name, string table)
		{
			return new Relation(db.CreateRelation(name, table, Type.Missing, Type.Missing));
		}

		public Relation CreateRelation(string name, string table, string foreigntable)
		{
			return new Relation(db.CreateRelation(name, table, foreigntable, Type.Missing));
		}

		public Relation CreateRelation(string name, string table, string foreigntable, RelationAttribute attributes)
		{
			return new Relation(db.CreateRelation(name, table, foreigntable, attributes));
		}

		[Obsolete("Use OpenRecordset instead.", false)]
		public Recordset CreateSnapshot(string source, RecordsetOption options)
		{
			return new Recordset(db.CreateSnapshot(source, options));
		}

		public TableDef CreateTableDef()
		{
			return new TableDef(db.CreateTableDef(Type.Missing, Type.Missing, Type.Missing, Type.Missing));
		}

		public TableDef CreateTableDef(string name)
		{
			return new TableDef(db.CreateTableDef(name, Type.Missing, Type.Missing, Type.Missing));
		}

		public TableDef CreateTableDef(string name, TableDefAttribute attributes)
		{
			return new TableDef(db.CreateTableDef(name, attributes, Type.Missing, Type.Missing));
		}

		public TableDef CreateTableDef(string name, TableDefAttribute attributes, string source)
		{
			return new TableDef(db.CreateTableDef(name, attributes, source, Type.Missing));
		}

		public TableDef CreateTableDef(string name, TableDefAttribute attributes, string source, string connect)
		{
			return new TableDef(db.CreateTableDef(name, attributes, source, connect));
		}

		[Obsolete("Use QueryDefs.Delete instead.", false)]
		public void DeleteQueryDef(string name)
		{
			db.DeleteQueryDef(name);
		}

		public void Execute(string source)
		{
			db.Execute(source, Type.Missing);
		}

		public void Execute(string source, RecordsetOption options)
		{
			db.Execute(source, options);
		}

		public int ExecuteSQL(string sqltext)
		{
			return db.ExecuteSQL(sqltext);
		}

		[Obsolete("Use e.g. Tabledefs[name].Fields instead.", false)]
		public Recordset ListFields(string name)
		{
			return new Recordset(db.ListFields(name));
		}

		[Obsolete("Use Tabledefs instead.", false)]
		public Recordset ListTables()
		{
			return new Recordset(db.ListTables());
		}

		public void MakeReplica(string name, string description, ReplicaType options)
		{
			db.MakeReplica(name, description, options);
		}

		public void NewPassword(string oldpwd, string newpwd)
		{
			db.NewPassword(oldpwd, newpwd);
		}

		[Obsolete("Use QueryDefs instead.", false)]
		public QueryDef OpenQueryDef(string name)
		{
			return new QueryDef(db.OpenQueryDef(name));
		}

		public Recordset OpenRecordset(string source)
		{
			return new Recordset(db.OpenRecordset(source, Type.Missing, Type.Missing, Type.Missing));
		}
		
		public Recordset OpenRecordset(string source, RecordsetType type)
		{
			return new Recordset(db.OpenRecordset(source, type, Type.Missing, Type.Missing));
		}
		
		public Recordset OpenRecordset(string source, RecordsetType type, RecordsetOption options)
		{
			return new Recordset(db.OpenRecordset(source, type, options, Type.Missing));
		}
		
		public Recordset OpenRecordset(string source, RecordsetType type, RecordsetOption options, LockType lockedits)
		{
			return new Recordset(db.OpenRecordset(source, type, options, lockedits));
		}

		[Obsolete("Use OpenRecordset instead.", false)]
		public Recordset OpenTable(string name, RecordsetOption options)
		{
			return new Recordset(db.OpenTable(name, options));
		}

		public void PopulatePartial(string dbname)
		{
			db.PopulatePartial(dbname);
		}

		public void Rollback()
		{
			db.Rollback();
		}

		public void Synchronize(string dbname, SynchronizeType exchange)
		{
			db.Synchronize(dbname, exchange);
		}

		public CollatingOrder CollatingOrder
		{
			get { return (CollatingOrder)db.CollatingOrder; }
		}

		public string Connect
		{
			get { return db.Connect; }
			set { db.Connect=value; }
		}

		public Connection Connection
		{
			get { return new Connection(db.Connection); }
		}

		public Containers Containers
		{
			get { return new Containers(db.Containers); }
		}

		public string DesignMasterID
		{
			get { return db.DesignMasterID; }
			set { db.DesignMasterID=value; }
		}

		public string Name
		{
			get { return db.Name; }
		}

		public Properties Properties
		{
			get { return new Properties(db.Properties); }
		}

		public QueryDefs QueryDefs
		{
			get { return new QueryDefs(db.QueryDefs); }
		}

		public short QueryTimeout
		{
			get { return db.QueryTimeout; }
			set { db.QueryTimeout=value; }
		}

		public int RecordsAffected
		{
			get { return db.RecordsAffected; }
		}

		public Recordsets Recordsets
		{
			get { return new Recordsets(db.Recordsets); }
		}

		public Relations Relations
		{
			get { return new Relations(db.Relations); }
		}

		public string ReplicaID
		{
			get { return db.ReplicaID; }
		}

		public TableDefs TableDefs
		{
			get{ return new TableDefs(db.TableDefs); }
		}

		public bool Transactions
		{
			get { return db.Transactions; }
		}

		public bool Updatable
		{
			get { return db.Updatable; }
		}

		public string Version
		{
			get { return db.Version; }
		}
	}

	class DatabasesEnumerator : System.Collections.IEnumerator
	{
		internal System.Collections.IEnumerator Enmtr;
		public DatabasesEnumerator(System.Collections.IEnumerator _Enmtr) { Enmtr=_Enmtr; }
		public void Reset() { Enmtr.Reset(); }
		public bool MoveNext() { return Enmtr.MoveNext(); }
		public object Current { get{ return new Database((DAO.Database)Enmtr.Current); } }
	}

	public class Databases
	{
		internal DAO.Databases dbs;

		public Databases(DAO.Databases _dbs) 
		{
			dbs=_dbs;
		}

		public short Count 
		{
			get { return dbs.Count; }
		}

		public System.Collections.IEnumerator GetEnumerator()
		{
			return new DatabasesEnumerator(dbs.GetEnumerator());
		}
		
		public void Refresh()
		{
			dbs.Refresh();
		}

		public Database this[string index]
		{
			get { return new Database(dbs[index]); }
		}

		public Database this[int index]
		{
			get { return new Database(dbs[index]); }
		}
	}
}
