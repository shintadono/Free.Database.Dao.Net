using System;

namespace Free.Database.Dao.Net
{
	public enum CollatingOrder
	{
		dbSortUndefined = -1,
		dbSortNeutral = 1024,
		dbSortArabic = 1025,
		dbSortChineseTraditional = 1028,
		dbSortCzech = 1029,
		dbSortNorwdan = 1030,
		dbSortGreek = 1032,
		dbSortGeneral = 1033,
		dbSortSpanish = 1034,
		dbSortHebrew = 1037,
		dbSortHungarian = 1038,
		dbSortIcelandic = 1039,
		dbSortJapanese = 1041,
		dbSortKorean = 1042,
		dbSortDutch = 1043,
		dbSortPolish = 1045,
		dbSortCyrillic = 1049,
		dbSortSwedFin = 1053,
		dbSortThai = 1054,
		dbSortTurkish = 1055,
		dbSortSlovenian = 1060,
		dbSortChineseSimplified = 2052,
		dbSortPDXNor = 1030,
		dbSortPDXIntl = 1033,
		dbSortPDXSwe = 1053
	}

	public enum CommitTransOptions
	{
		dbForceOSFlush = 1
	}

	public enum CursorDriver
	{
		dbUseDefaultCursor = -1,
		dbUseODBCCursor = 1,
		dbUseServerCursor = 2,
		dbUseClientBatchCursor = 3,
		dbUseNoCursor = 4
	}

	public enum DatabaseType
	{
		dbVersion10 = 1,
		dbEncrypt = 2,
		dbDecrypt = 4,
		dbVersion11 = 8,
		dbVersion20 = 16,
		dbVersion30 = 32
	}

	public enum DataType
	{
		dbBoolean = 1,
		dbByte = 2,
		dbInteger = 3,
		dbLong = 4,
		dbCurrency = 5,
		dbSingle = 6,
		dbDouble = 7,
		dbDate = 8,
		dbBinary = 9,
		dbText = 10,
		dbLongBinary = 11,
		dbMemo = 12,
		dbGUID = 15,
		dbBigInt = 16,
		dbVarBinary = 17,
		dbChar = 18,
		dbNumeric = 19,
		dbDezimal = 20,
		dbFloat = 21,
		dbTime = 22,
		dbTimeStamp = 23
	}

	/* public enum _DAOSuppHelp
	{
		KeepLocal = 0,
		LogMessages = 0,
		Replicable = 0,
		ReplicableBool = 0,
		V1xNullBehavior = 0
	}*/

	public enum DriverPrompt
	{
		dbDriverComplete = 0,
		dbDriverNoPrompt = 1,
		dbDriverPrompt = 2,
		dbDriverCompleteRequired = 3,
		dbRunAsync = 1024
	}

	public enum EditMode
	{
		dbEditNone = 0,
		dbEditInProgress = 1,
		dbEditAdd = 2,
		dbEditChanged = 4,
		dbEditDeleted = 8,
		dbEditNew = 16
	}

	public enum FieldAttribute
	{
		dbDescending = 1,
		dbFixedField = 1,
		dbVariableField = 2,
		dbAutoIncrField = 16,
		dbUpdatableField = 32,
		dbSystemField = 8192,
		dbHyperlinkField = 32768
	}

	public enum Idle
	{
		dbFreeLocks = 1,
		dbRefreshCache = 8
	}

	public enum LockType
	{
		dbOptimisticValue = 1,
		dbPessimistic = 2,
		dbOptimistic = 3,
		dbReadOnly = 4,
		dbOptimisticBatch = 5
	}

	public enum ParameterDirection
	{
		dbParamInput = 1,
		dbParamOutput = 2,
		dbParamInputOutput = 3,
		dbParamReturnValue = 4
	}

	public enum Permission
	{
		dbSecNoAccess = 0,
		dbSecCreate = 1,
		dbSecDBCreate = 1,
		dbSecDBOpen = 2,
		dbSecReadDef = 4,
		dbSecDBExclusive = 4,
		dbSecDBAdmin = 8,
		dbSecRetrieveData = 20,		// 0x00014
		dbSecInsertData = 32,		// 0x00020
		dbSecReplaceData = 64,		// 0x00040
		dbSecDeleteData = 128,		// 0x00080
		dbSecDelete = 65536,		// 0x10000
		dbSecWriteDef = 65548,		// 0x1000C
		dbSecReadSec = 131072,		// 0x20000
		dbSecWriteSec = 262144,		// 0x40000
		dbSecWriteOwner = 524288,	// 0x80000
		dbSecFullAccess = 1048575	// 0xFFFFF
	}

	public enum QueryDefState
	{
		dbQPrepare = 1,
		dbQUnprepare = 2
	}

	public enum QueryDefType
	{
		dbQSelect = 0,
		dbQCrosstab = 16,
		dbQDelete = 32,
		dbQUpdate = 48,
		dbQAppend = 64,
		dbQMakeTable = 80,
		dbQDDL = 96,
		dbQSQLPassThrough = 112,
		dbQSetOperation = 128,
		dbQSPTBulk = 144,
		dbQCompound = 160,
		dbQProcedure = 224,
		dbQAction = 240
	}

	public enum RecordsetOption
	{
		dbDenyWrite = 1,
		dbDenyRead = 2,
		dbReadOnly = 4,
		dbAppendOnly = 8,
		dbInconsistent = 16,
		dbConsistent = 32,
		dbSQLPassThrough = 64,
		dbFailOnError = 128,
		dbForwardOnly = 256,
		dbSeeChanges = 512,
		dbRunAsync = 1024,
		dbExecDirect = 2048
	}

	public enum RecordsetType
	{
		dbOpenTable = 1,
		dbOpenDynaset = 2,
		dbOpenSnapshot = 4,
		dbOpenForwardOnly = 8,
		dbOpenDynamic = 16
	}

	public enum RecordStatus
	{
		dbRecordUnmodified = 0,
		dbRecordModified = 1,
		dbRecordNew = 2,
		dbRecordDeleted = 3,
		dbRecordDBDeleted = 4
	}

	public enum RelationAttribute
	{
		dbRelationUnique = 1,
		dbRelationDontEnforce = 2,
		dbRelationInherited = 4,
		dbRelationUpdateCascade = 256,
		dbRelationDeleteCascade = 4096,
		dbRelationLeft = 16777216,
		dbRelationRight = 33554432
	}

	public enum ReplicaType
	{
		dbRepMakePartial = 1,
		dbRepMakeReadOnly = 2
	}

	public enum SetOption
	{
		dbPageTimeout = 6,
		dbMaxBufferSize = 8,
		dbLockRetry = 57,
		dbUserCommitSync = 58,
		dbImplicitCommitSync = 59,
		dbExclusiveAsyncDelay = 60,
		dbSharedAsyncDelay = 61,
		dbMaxLocksPerFile = 62,
		dbLockDelay = 63,
		dbRecycleLVs = 65,
		dbFlushTransactionTimeout = 66
	}

	public enum SynchronizeType
	{
		dbRepExportChanges = 1,
		dbRepImportChanges = 2,
		dbRepImpExpChanges = 4,
		dbRepSyncInternet = 16
	}

	public enum TableDefAttribute
	{
		dbSystemObject = -2147483646,
		dbHiddenObject = 1,
		dbAttachExclusive = 65536,
		dbAttachSavePWD = 131072,
		dbAttachedODBC = 536870912,
		dbAttachedTable = 1073741824,
	}

	public enum UpdateCriteria
	{
		dbCriteriaKey = 1,
		dbCriteriaModValues = 2,
		dbCriteriaAllCols = 4,
		dbCriteriaTimestamp = 8,
		dbCriteriaDeleteInsert = 16,
		dbCriteriaUpdate = 32
	}

	public enum UpdateType
	{
		dbUpdateRegular = 1,
		dbUpdateCurrentRecord = 2,
		dbUpdateBatch = 4
	}

	public enum WorkspaceType
	{
		dbUseODBC = 1,
		dbUseJet = 2
	}
}
