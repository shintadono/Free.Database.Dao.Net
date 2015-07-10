using System;

namespace Free.Database.Dao.Net
{
	public class Recordset
	{
		internal DAO.Recordset rs;

		public Recordset(DAO.Recordset _rs)
		{
			rs=_rs;
		}

		[Obsolete("Use CancelUpdate instead.", false)]
		public void _30_CancelUpdate()
		{
			rs._30_CancelUpdate();
		}

		[Obsolete("Use MoveLast instead.", false)]
		public void _30_MoveLast()
		{
			rs._30_MoveLast();
		}

		[Obsolete("Use Update instead.", false)]
		public void _30_Update()
		{
			rs._30_Update();
		}

		public void AddNew()
		{
			rs.AddNew();
		}

		public void Cancel()
		{
			rs.Cancel();
		}

		public void CancelUpdate(UpdateType type)
		{
			rs.CancelUpdate((int)type);
		}

		public Recordset Clone()
		{
			return new Recordset(rs.Clone());
		}
		
		public void Close()
		{
			rs.Close();
		}

		public QueryDef CopyQueryDef()
		{
			return new QueryDef(rs.CopyQueryDef());
		}

		[Obsolete("Use OpenRecordset instead.", false)]
		public Recordset CreateDynaset(RecordsetOption options, bool inconsistent)
		{
			return new Recordset(rs.CreateDynaset(options, inconsistent));
		}

		[Obsolete("Use OpenRecordset instead.", false)]
		public Recordset CreateSnapshot(RecordsetOption options)
		{
			return new Recordset(rs.CreateSnapshot(options));
		}

		public void Delete()
		{
			rs.Delete();
		}

		public void Edit()
		{
			rs.Edit();
		}

		public void FillCache()
		{
			rs.FillCache(System.Type.Missing, System.Type.Missing);
		}

		public void FillCache(int rows)
		{
			rs.FillCache(rows, System.Type.Missing);
		}

		public void FillCache(int rows, string startbookmark)
		{
			rs.FillCache(rows, startbookmark);
		}

		public void FillCache(string startbookmark)
		{
			rs.FillCache(System.Type.Missing, startbookmark);
		}

		public void FindFirst(string criteria)
		{
			rs.FindFirst(criteria);
		}

		public void FindLast(string criteria)
		{
			rs.FindLast(criteria);
		}

		public void FindNext(string criteria)
		{
			rs.FindNext(criteria);
		}

		public void FindPrevious(string criteria)
		{
			rs.FindPrevious(criteria);
		}

		[Obsolete("Fields[index].Value is nicer, but get_Collect is faster.", false)]
		public object get_Collect(string index)
		{
			return rs.get_Collect(index);
		}

		[Obsolete("Fields[index].Value is nicer, but get_Collect is faster.", false)]
		public object get_Collect(int index)
		{
			return rs.get_Collect(index);
		}

		public System.Array GetRows(int numrows)
		{
			return (System.Array)rs.GetRows(numrows);
		}

		[Obsolete("Use Fields instead.", false)]
		public Recordset ListFields()
		{
			return new Recordset(rs.ListFields());
		}

		[Obsolete("Use Indexes instead.", false)]
		public Recordset ListIndexes()
		{
			return new Recordset(rs.ListIndexes());
		}

		public void Move(int rows)
		{
			rs.Move(rows, System.Type.Missing);
		}

		public void Move(int rows, string startbookmark)
		{
			rs.Move(rows, startbookmark);
		}

		public void MoveFirst()
		{
			rs.MoveFirst();
		}

		public void MoveLast()
		{
			rs.MoveLast(0);
		}
		
		public void MoveLast(RecordsetOption options)
		{
			rs.MoveLast((int)options);
		}

		public void MoveNext()
		{
			rs.MoveNext();
		}

		public void MovePrevious()
		{
			rs.MovePrevious();
		}
		
		public bool NextRecordset()
		{
			return rs.NextRecordset();
		}

		public Recordset OpenRecordset()
		{
			return new Recordset(rs.OpenRecordset(System.Type.Missing, System.Type.Missing));
		}

		public Recordset OpenRecordset(RecordsetType type)
		{
			return new Recordset(rs.OpenRecordset(type, System.Type.Missing));
		}
		
		public Recordset OpenRecordset(RecordsetType type, RecordsetOption options)
		{
			return new Recordset(rs.OpenRecordset(type, options));
		}

		public void Requery()
		{
			rs.Requery(System.Type.Missing);
		}

		public void Requery(QueryDef newquerydef)
		{
			rs.Requery(newquerydef.qd);
		}

		[Obsolete("Fields[index].Value is nicer, but set_Collect is faster.", false)]
		public void set_Collect(string index, object val)
		{
			rs.set_Collect(index, val);
		}

		[Obsolete("Fields[index].Value is nicer, but set_Collect is faster.", false)]
		public void set_Collect(int index, object val)
		{
			rs.set_Collect(index, val);
		}

		[Obsolete("Fields[index].Value is nicer, but set_Collect is faster.", false)]
		public void put_Collect(string index, object val)
		{
			rs.set_Collect(index, val);
		}

		[Obsolete("Fields[index].Value is nicer, but set_Collect is faster.", false)]
		public void put_Collect(int index, object val)
		{
			rs.set_Collect(index, val);
		}

		public void Seek(string comparison, object key1, params object[] keys)
		{
			object[] k=new object[12];
			keys.CopyTo(k, 0);
			for(int i=keys.Length; i<12; i++) k[i]=System.Type.Missing;

			rs.Seek(comparison, key1, k[0], k[1], k[2], k[3], k[4], k[5], k[6], k[7], k[8], k[9],
				k[10], k[11]);
		}

		public void Update()
		{
			rs.Update((int)UpdateType.dbUpdateRegular, false);
		}

		public void Update(UpdateType type)
		{
			rs.Update((int)type, false);
		}

		public void Update(UpdateType type, bool force)
		{
			rs.Update((int)type, force);
		}

		public int AbsolutePosition
		{
			get { return rs.AbsolutePosition; }
			set { rs.AbsolutePosition=value; }
		}

		public int BatchCollisionCount
		{
			get { return rs.BatchCollisionCount; }
		}

		// returns array of Bookmarks
		public object BatchCollisions
		{
			get { return rs.BatchCollisions; }
		}

		public int BatchSize
		{
			get { return rs.BatchSize; }
			set { rs.BatchSize=value; }
		}

		// returns byte[]
		public System.Array Bookmark
		{
			get { return rs.get_Bookmark(); }
			set { rs.set_Bookmark(ref value); }
		}

		public bool Bookmarkable
		{
			get { return rs.Bookmarkable; }
		}

		public bool BOF
		{
			get { return rs.BOF; }
		}

		public int CacheSize
		{
			get { return rs.CacheSize; }
			set { rs.CacheSize=value; }
		}

		// returns byte[] ^= Bookmark's return type
		public System.Array CacheStart
		{
			get { return rs.get_CacheStart(); }
			set { rs.set_CacheStart(ref value); }
		}

		public Connection Connection
		{
			get { return new Connection(rs.Connection); }
			set { rs.Connection=value.con; }
		}

		public DateTime DateCreated
		{
			get { return (DateTime)rs.DateCreated; }
		}

		public EditMode EditMode
		{
			get { return (EditMode)rs.EditMode; }
		}

		public bool EOF
		{
			get { return rs.EOF; }
		}

		public Fields Fields
		{
			get { return new Fields(rs.Fields); }
		}

		public string Filter
		{
			get { return rs.Filter; }
			set { rs.Filter=value; }
		}

		public int hStmt
		{
			get { return rs.hStmt; }
		}

		public string Index
		{
			get { return rs.Index; }
			set { rs.Index=value; }
		}

		public Indexes Indexes
		{
			get { return new Indexes(rs.Indexes); }
		}

		public System.Array LastModified
		{
			get { return rs.LastModified; }
		}

		public DateTime LastUpdated
		{
			get { return (DateTime)rs.LastUpdated; }
		}

		public bool LockEdits
		{
			get { return rs.LockEdits; }
			set { rs.LockEdits=value; }
		}

		public string Name
		{
			get { return rs.Name; }
		}

		public bool NoMatch
		{
			get { return rs.NoMatch; }
		}

		public int ODBCFetchCount
		{
			get { return rs.ODBCFetchCount; }
		}

		public int ODBCFetchDelay
		{
			get { return rs.ODBCFetchDelay; }
		}

		public Database Parent
		{
			get { return new Database(rs.Parent); }
		}

		public float PercentPosition
		{
			get { return rs.PercentPosition; }
			set { rs.PercentPosition=value; }
		}

		public Properties Properties
		{
			get { return new Properties(rs.Properties); }
		}

		public int RecordCount
		{
			get { return rs.RecordCount; }
		}

		public RecordStatus RecordStatus
		{
			get { return (RecordStatus)rs.RecordStatus; }
		}

		public bool Restartable
		{
			get { return rs.Restartable; }
		}

		public string Sort
		{
			get { return rs.Sort; }
			set { rs.Sort=value; }
		}

		public bool StillExecuting
		{
			get { return rs.StillExecuting; }
		}

		public bool Transactions
		{
			get { return rs.Transactions; }
		}

		public RecordsetType Type
		{
			get { return (RecordsetType)rs.Type; }
		}

		public bool Updatable
		{
			get { return rs.Updatable; }
		}

		public UpdateCriteria UpdateOptions
		{
			get { return (UpdateCriteria)rs.UpdateOptions; }
			set { rs.UpdateOptions=(int)value; }
		}

		public string ValidationRule
		{
			get { return rs.ValidationRule; }
		}

		public string ValidationText
		{
			get { return rs.ValidationText; }
		}
	}

	class RecordsetsEnumerator : System.Collections.IEnumerator
	{
		internal System.Collections.IEnumerator Enmtr;
		public RecordsetsEnumerator(System.Collections.IEnumerator _Enmtr) { Enmtr=_Enmtr; }
		public void Reset() { Enmtr.Reset(); }
		public bool MoveNext() { return Enmtr.MoveNext(); }
		public object Current { get{ return new Recordset((DAO.Recordset)Enmtr.Current); } }
	}

	public class Recordsets
	{
		internal DAO.Recordsets rss;

		public Recordsets(DAO.Recordsets _rss)
		{
			rss=_rss;
		}

		public short Count
		{
			get { return rss.Count; }
		}

		public System.Collections.IEnumerator GetEnumerator()
		{
			return new RecordsetsEnumerator(rss.GetEnumerator());
		}

		public void Refresh()
		{
			rss.Refresh();
		}

		public Recordset this[string index]
		{
			get { return new Recordset(rss[index]); }
		}

		public Recordset this[int index]
		{
			get { return new Recordset(rss[index]); }
		}
	}
}
