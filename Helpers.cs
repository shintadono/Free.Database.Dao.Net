using System;
using System.Collections.Generic;
using System.Text;

namespace Free.Database.Dao.Net.Helpers
{
	public static class DAOHelpers
	{
		/// <summary>
		/// Changes field sizes after table creation
		/// </summary>
		/// <param name="Db"></param>
		/// <param name="sTable"></param>
		/// <param name="sField"></param>
		/// <param name="iNewSize"></param>
		public static void ChangeFieldSize(Database Db, string sTable, string sField, int iNewSize)
		{
			Recordset Rs;
			int iPosition;
			Field FieldCreator;

			FieldCreator = Db.TableDefs[sTable].CreateField(sField + "_tmp", Db.TableDefs[sTable].Fields[sField].Type, iNewSize);
			FieldCreator.AllowZeroLength = true;
			FieldCreator.Attributes = FieldAttribute.dbUpdatableField;
			Db.TableDefs[sTable].Fields.Append(FieldCreator);

			// Open table and copy field data to temp field
			Rs = Db.OpenRecordset("SELECT " + sField + ", " + sField + "_tmp FROM " + sTable);

			if (Rs.RecordCount > 0)
			{
				while (!Rs.EOF)
				{
					Rs.Edit();
					Rs.Fields[sField].Value = Rs.Fields[sField + "_tmp"].Value;
					Rs.Update();
					Rs.MoveNext();
				}
			}

			Rs.Close();
			Rs = null;

			// Save OrdinalPosition
			iPosition = Db.TableDefs[sTable].Fields[sField].OrdinalPosition;

			// Delete old field
			Db.TableDefs[sTable].Fields.Delete(sField);

			// Rename temp field
			Db.TableDefs[sTable].Fields[sField + "_tmp"].Name = sField;

			// Restore Ordinalposition
			Db.TableDefs[sTable].Fields[sField].OrdinalPosition = (short)iPosition;

		}
	}
}
