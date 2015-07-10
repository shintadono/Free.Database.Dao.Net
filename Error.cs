using System;

namespace Free.Database.Dao.Net
{
	public class Error
	{
		internal DAO.Error err;

		public Error(DAO.Error _err)
		{
			err=_err;
		}

		public string Description
		{
			get { return err.Description; }
		}

		public int HelpContext
		{
			get { return err.HelpContext; }
		}

		public string HelpFile
		{
			get { return err.HelpFile; }
		}

		public int Number
		{
			get { return err.Number; }
		}

		public string Source
		{
			get { return err.Source; }
		}
	}

	class ErrorsEnumerator : System.Collections.IEnumerator
	{
		internal System.Collections.IEnumerator Enmtr;
		public ErrorsEnumerator(System.Collections.IEnumerator _Enmtr) { Enmtr=_Enmtr; }
		public void Reset() { Enmtr.Reset(); }
		public bool MoveNext() { return Enmtr.MoveNext(); }
		public object Current { get{ return new Error((DAO.Error)Enmtr.Current); } }
	}

	public class Errors
	{
		internal DAO.Errors errs;

		public Errors(DAO.Errors _errs)
		{
			errs=_errs;
		}

		public short Count
		{
			get { return errs.Count; }
		}

		public System.Collections.IEnumerator GetEnumerator()
		{
			return new ErrorsEnumerator(errs.GetEnumerator());
		}

		public void Refresh()
		{
			errs.Refresh();
		}

		public Error this[int index] 
		{
			get { return new Error(errs[index]); }
		}
	}
}
