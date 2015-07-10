using System;

namespace Free.Database.Dao.Net
{
	public class Parameter
	{
		internal DAO.Parameter par;

		public Parameter(DAO.Parameter _par)
		{
			par=_par;
		}

		public ParameterDirection Direction
		{
			get { return (ParameterDirection)par.Direction; }
			set { par.Direction=(short)value; }
		}

		public string Name
		{
			get { return par.Name; }
		}

		public Properties Properties
		{
			get { return new Properties(par.Properties); }
		}

		public DataType Type
		{
			get { return (DataType)par.Type; }
			set { par.Type=(short)value; }
		}

		public object Value
		{
			get { return par.Value; }
			set { par.Value=value; }
		}
	}

	class ParametersEnumerator : System.Collections.IEnumerator
	{
		internal System.Collections.IEnumerator Enmtr;
		public ParametersEnumerator(System.Collections.IEnumerator _Enmtr) { Enmtr=_Enmtr; }
		public void Reset() { Enmtr.Reset(); }
		public bool MoveNext() { return Enmtr.MoveNext(); }
		public object Current { get { return new Parameter((DAO.Parameter)Enmtr.Current); } }
	}

	namespace ParametersNS
	{
		public class Parameters
		{
			internal DAO.Parameters pars;

			public Parameters(DAO.Parameters _pars)
			{
				pars=_pars;
			}

			public short Count
			{
				get { return pars.Count; }
			}

			public System.Collections.IEnumerator GetEnumerator()
			{
				return new ParametersEnumerator(pars.GetEnumerator());
			}

			public void Refresh()
			{
				pars.Refresh();
			}

			public Parameter this[string index]
			{
				get { return new Parameter(pars[index]); }
			}

			public Parameter this[int index]
			{
				get { return new Parameter(pars[index]); }
			}
		}
	}
}
