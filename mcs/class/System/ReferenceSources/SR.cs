//
// Resource strings referenced by the code.
//
// Copyright 2014 Xamarin Inc
//
partial class SR
{
	public static object GetObject (string name)
	{
		// The PropertyGrid code in WinForms and the corresponding tests
		// rely on PropertyCategoryDefault returning the correct value.
		// Handle this special case until we have proper resource lookup. 
		if (name == "PropertyCategoryDefault")
			return "Misc";

		return name;
	}

	public const string UnexpectedOpcode = "UnexpectedOpcode";
	public const string BeginIndexNotNegative = "BeginIndexNotNegative";
	public const string CountTooSmall = "CountTooSmall";
	public const string ReplacementError = "ReplacementError";
	public const string BadClassInCharRange = "BadClassInCharRange";
	public const string TooManyAlternates = "TooManyAlternates";
	public const string MakeException = "MakeException";
	public const string IncompleteSlashP = "IncompleteSlashP";
	public const string MalformedSlashP = "MalformedSlashP";
	public const string CaptureGroupOutOfRange = "CaptureGroupOutOfRange";
	public const string InvalidGroupName = "InvalidGroupName";
	public const string UndefinedBackref = "UndefinedBackref";
	public const string UndefinedNameref = "UndefinedNameref";
	public const string UnrecognizedControl = "UnrecognizedControl";
	
	public const string AlternationCantCapture = "AlternationCantCapture";
	public const string AlternationCantHaveComment = "AlternationCantHaveComment";
	public const string Arg_InvalidArrayType = "Arg_InvalidArrayType";
	public const string Arg_RankMultiDimNotSupported = "Arg_RankMultiDimNotSupported";
	public const string ArgumentNull_ArrayWithNullElements = "ArgumentNull_ArrayWithNullElements";
	public const string CapnumNotZero = "CapnumNotZero";
	public const string EnumNotStarted = "EnumNotStarted";
	public const string IllegalCondition = "IllegalCondition";
	public const string IllegalDefaultRegexMatchTimeoutInAppDomain = "IllegalDefaultRegexMatchTimeoutInAppDomain";
	public const string IllegalEndEscape = "IllegalEndEscape";
	public const string IllegalRange = "IllegalRange";
	public const string InvalidNullEmptyArgument = "Invalid empty argument {0}";
	public const string InternalError = "InternalError";
	public const string LengthNotNegative = "LengthNotNegative";
	public const string MalformedNameRef = "MalformedNameRef";
	public const string MalformedReference = "MalformedReference";
	public const string MissingControl = "MissingControl";
	public const string NestedQuantify = "NestedQuantify";
	public const string NoResultOnFailed = "NoResultOnFailed";
	public const string NotEnoughParens = "NotEnoughParens";
	public const string OnlyAllowedOnce = "OnlyAllowedOnce";
	public const string QuantifyAfterNothing = "QuantifyAfterNothing";
	public const string RegexMatchTimeoutException_Occurred = "RegexMatchTimeoutException_Occurred";
	public const string ReversedCharRange = "ReversedCharRange";
	public const string SubtractionMustBeLast = "SubtractionMustBeLast";
	public const string TooFewHex = "TooFewHex";
	public const string TooManyParens = "TooManyParens";
	public const string UndefinedNameRef = "UndefinedNameRef";
	public const string UndefinedReference = "UndefinedReference";
	public const string UnimplementedState = "UnimplementedState";
	public const string UnknownProperty = "UnknownProperty";
	public const string UnrecognizedEscape = "UnrecognizedEscape";
	public const string UnrecognizedGrouping = "UnrecognizedGrouping";
	public const string UnterminatedBracket = "UnterminatedBracket";
	public const string UnterminatedComment = "UnterminatedComment";

	public const string Arg_ArrayPlusOffTooSmall = "Arg_ArrayPlusOffTooSmall";
	public const string Arg_InsufficientSpace = "Arg_InsufficientSpace";
	public const string Arg_MultiRank = "Arg_MultiRank";
	public const string Arg_NonZeroLowerBound = "Arg_NonZeroLowerBound";
	public const string Arg_WrongType = "Arg_WrongType";
	public const string ArgumentOutOfRange_Index = "ArgumentOutOfRange_Index";
	public const string ArgumentOutOfRange_NeedNonNegNum = "ArgumentOutOfRange_NeedNonNegNum";
	public const string ArgumentOutOfRange_NeedNonNegNumRequired = "ArgumentOutOfRange_NeedNonNegNumRequired";
	public const string ArgumentOutOfRange_SmallCapacity = "ArgumentOutOfRange_SmallCapacity";
	public const string Argument_AddingDuplicate = "Argument_AddingDuplicate";
	public const string Argument_ImplementIComparable = "Argument_ImplementIComparable";
	public const string Argument_InvalidOffLen = "Argument_InvalidOffLen";
	public const string ExternalLinkedListNode = "ExternalLinkedListNode";
	public const string IndexOutOfRange = "IndexOutOfRange";
	public const string InvalidOperation_CannotRemoveFromStackOrQueue = "InvalidOperation_CannotRemoveFromStackOrQueue";
	public const string InvalidOperation_EmptyCollection = "InvalidOperation_EmptyCollection";
	public const string InvalidOperation_EmptyQueue = "InvalidOperation_EmptyQueue";
	public const string InvalidOperation_EmptyStack = "InvalidOperation_EmptyStack";
	public const string InvalidOperation_EnumEnded = "InvalidOperation_EnumEnded";
	public const string InvalidOperation_EnumFailedVersion = "InvalidOperation_EnumFailedVersion";
	public const string InvalidOperation_EnumNotStarted = "InvalidOperation_EnumNotStarted";
	public const string InvalidOperation_EnumOpCantHappen = "InvalidOperation_EnumOpCantHappen";
	public const string Invalid_Array_Type = "Invalid_Array_Type";
	public const string LinkedListEmpty = "LinkedListEmpty";
	public const string LinkedListNodeIsAttached = "LinkedListNodeIsAttached";
	public const string NotSupported_KeyCollectionSet = "NotSupported_KeyCollectionSet";
	public const string NotSupported_SortedListNestedWrite = "NotSupported_SortedListNestedWrite";
	public const string NotSupported_ValueCollectionSet = "NotSupported_ValueCollectionSet";
	public const string Serialization_InvalidOnDeser = "Serialization_InvalidOnDeser";
	public const string Serialization_MismatchedCount = "Serialization_MismatchedCount";
	public const string Serialization_MissingValues = "Serialization_MissingValues";

	public const string BlockingCollection_Add_ConcurrentCompleteAdd = "BlockingCollection_Add_ConcurrentCompleteAdd";
	public const string BlockingCollection_Add_Failed = "BlockingCollection_Add_Failed";
	public const string BlockingCollection_CantAddAnyWhenCompleted = "BlockingCollection_CantAddAnyWhenCompleted";
	public const string BlockingCollection_CantTakeAnyWhenAllDone = "BlockingCollection_CantTakeAnyWhenAllDone";
	public const string BlockingCollection_CantTakeWhenDone = "BlockingCollection_CantTakeWhenDone";
	public const string BlockingCollection_Completed = "BlockingCollection_Completed";
	public const string BlockingCollection_CopyTo_IncorrectType = "BlockingCollection_CopyTo_IncorrectType";
	public const string BlockingCollection_CopyTo_MultiDim = "BlockingCollection_CopyTo_MultiDim";
	public const string BlockingCollection_CopyTo_NonNegative = "BlockingCollection_CopyTo_NonNegative";
	public const string BlockingCollection_CopyTo_TooManyElems = "BlockingCollection_CopyTo_TooManyElems";
	public const string BlockingCollection_Disposed = "BlockingCollection_Disposed";
	public const string BlockingCollection_Take_CollectionModified = "BlockingCollection_Take_CollectionModified";
	public const string BlockingCollection_TimeoutInvalid = "BlockingCollection_TimeoutInvalid";
	public const string BlockingCollection_ValidateCollectionsArray_DispElems = "BlockingCollection_ValidateCollectionsArray_DispElems";
	public const string BlockingCollection_ValidateCollectionsArray_LargeSize = "BlockingCollection_ValidateCollectionsArray_LargeSize";
	public const string BlockingCollection_ValidateCollectionsArray_NullElems = "BlockingCollection_ValidateCollectionsArray_NullElems";
	public const string BlockingCollection_ValidateCollectionsArray_ZeroSize = "BlockingCollection_ValidateCollectionsArray_ZeroSize";
	public const string BlockingCollection_ctor_BoundedCapacityRange = "BlockingCollection_ctor_BoundedCapacityRange";
	public const string BlockingCollection_ctor_CountMoreThanCapacity = "BlockingCollection_ctor_CountMoreThanCapacity";
	public const string Common_OperationCanceled = "Common_OperationCanceled";
	public const string ConcurrentBag_CopyTo_ArgumentNullException = "ConcurrentBag_CopyTo_ArgumentNullException";
	public const string ConcurrentBag_CopyTo_ArgumentOutOfRangeException = "ConcurrentBag_CopyTo_ArgumentOutOfRangeException";
	public const string ConcurrentBag_Ctor_ArgumentNullException = "ConcurrentBag_Ctor_ArgumentNullException";
	public const string ConcurrentCollection_SyncRoot_NotSupported = "ConcurrentCollection_SyncRoot_NotSupported";

	public const string ArrayConverterText = "{0} Array";
	public const string Async_AsyncEventArgs_Cancelled = "Async_AsyncEventArgs_Cancelled";
	public const string Async_AsyncEventArgs_Error = "Async_AsyncEventArgs_Error";
	public const string Async_AsyncEventArgs_UserState = "Async_AsyncEventArgs_UserState";
	public const string Async_ExceptionOccurred = "Async_ExceptionOccurred";
	public const string Async_NullDelegate = "Async_NullDelegate";
	public const string Async_OperationAlreadyCompleted = "Async_OperationAlreadyCompleted";
	public const string Async_OperationCancelled = "Async_OperationCancelled";
	public const string Async_ProgressChangedEventArgs_ProgressPercentage = "Async_ProgressChangedEventArgs_ProgressPercentage";
	public const string Async_ProgressChangedEventArgs_UserState = "Async_ProgressChangedEventArgs_UserState";
	public const string BackgroundWorker_CancellationPending = "BackgroundWorker_CancellationPending";
	public const string BackgroundWorker_Desc = "BackgroundWorker_Desc";
	public const string BackgroundWorker_DoWork = "BackgroundWorker_DoWork";
	public const string BackgroundWorker_DoWorkEventArgs_Argument = "BackgroundWorker_DoWorkEventArgs_Argument";
	public const string BackgroundWorker_DoWorkEventArgs_Result = "BackgroundWorker_DoWorkEventArgs_Result";
	public const string BackgroundWorker_IsBusy = "BackgroundWorker_IsBusy";
	public const string BackgroundWorker_ProgressChanged = "BackgroundWorker_ProgressChanged";
	public const string BackgroundWorker_RunWorkerCompleted = "BackgroundWorker_RunWorkerCompleted";
	public const string BackgroundWorker_WorkerAlreadyRunning = "BackgroundWorker_WorkerAlreadyRunning";
	public const string BackgroundWorker_WorkerDoesntReportProgress = "BackgroundWorker_WorkerDoesntReportProgress";
	public const string BackgroundWorker_WorkerDoesntSupportCancellation = "BackgroundWorker_WorkerDoesntSupportCancellation";
	public const string BackgroundWorker_WorkerReportsProgress = "BackgroundWorker_WorkerReportsProgress";
	public const string BackgroundWorker_WorkerSupportsCancellation = "BackgroundWorker_WorkerSupportsCancellation";
	public const string CHECKOUTCanceled = "CHECKOUTCanceled";
	public const string CantModifyListSortDescriptionCollection = "CantModifyListSortDescriptionCollection";
	public const string CollectionConverterText = "(Collection)";
	public const string ConvertFromException = "{0} cannot convert from {1}.";
	public const string ConvertInvalidPrimitive = "{0} is not a valid value for {1}.";
	public const string ConvertToException = "'{0}' is unable to convert '{1}' to '{2}'.";
	public const string CultureInfoConverterDefaultCultureString = "(Default)";
	public const string CultureInfoConverterInvalidCulture = "The {0} culture cannot be converted to a CultureInfo object on this computer.";
	public const string DuplicateComponentName = "Duplicate component name '{0}'.  Component names must be unique and case-insensitive.";
	public const string EnumConverterInvalidValue = "The value '{0}' is not a valid value for the enum '{1}'.";
	public const string ErrorBadExtenderType = "ErrorBadExtenderType";
	public const string ErrorInvalidEventHandler = "ErrorInvalidEventHandler";
	public const string ErrorInvalidEventType = "ErrorInvalidEventType";
	public const string ErrorInvalidPropertyType = "ErrorInvalidPropertyType";
	public const string ErrorInvalidServiceInstance = "ErrorInvalidServiceInstance";
	public const string ErrorMissingEventAccessors = "ErrorMissingEventAccessors";
	public const string ErrorMissingPropertyAccessors = "ErrorMissingPropertyAccessors";
	public const string ErrorPropertyAccessorException = "ErrorPropertyAccessorException";
	public const string ErrorServiceExists = "The service {0} already exists in the service container.";
	public const string ISupportInitializeDescr = "ISupportInitializeDescr";
	public const string InstanceCreationEditorDefaultText = "InstanceCreationEditorDefaultText";
	public const string InstanceDescriptorCannotBeStatic = "InstanceDescriptorCannotBeStatic";
	public const string InstanceDescriptorLengthMismatch = "InstanceDescriptorLengthMismatch";
	public const string InstanceDescriptorMustBeReadable = "InstanceDescriptorMustBeReadable";
	public const string InstanceDescriptorMustBeStatic = "InstanceDescriptorMustBeStatic";
	public const string InvalidArgument = "InvalidArgument";
	public const string InvalidEnumArgument = "The value of argument '{0}' ({1}) is invalid for Enum type '{2}'.";
	public const string InvalidMemberName = "InvalidMemberName";
	public const string InvalidNullArgument = "InvalidNullArgument";
	public const string LicExceptionTypeAndInstance = "LicExceptionTypeAndInstance";
	public const string LicExceptionTypeOnly = "LicExceptionTypeOnly";
	public const string LicMgrAlreadyLocked = "LicMgrAlreadyLocked";
	public const string LicMgrContextCannotBeChanged = "LicMgrContextCannotBeChanged";
	public const string LicMgrDifferentUser = "LicMgrDifferentUser";
	public const string MaskedTextProviderInvalidCharError = "MaskedTextProviderInvalidCharError";
	public const string MaskedTextProviderMaskInvalidChar  = "MaskedTextProviderMaskInvalidChar ";
	public const string MaskedTextProviderMaskNullOrEmpty = "MaskedTextProviderMaskNullOrEmpty";
	public const string MaskedTextProviderPasswordAndPromptCharError = "MaskedTextProviderPasswordAndPromptCharError";
	public const string MemberRelationshipService_RelationshipNotSupported = "MemberRelationshipService_RelationshipNotSupported";
	public const string MetaExtenderName = "MetaExtenderName";
	public const string MultilineStringConverterText = "(Text)";
	public const string NullableConverterBadCtorArg = "NullableConverterBadCtorArg";
	public const string PropertyCategoryAsynchronous = "PropertyCategoryAsynchronous";
	public const string PropertyTabAttributeArrayLengthMismatch = "PropertyTabAttributeArrayLengthMismatch";
	public const string PropertyTabAttributeBadPropertyTabScope = "PropertyTabAttributeBadPropertyTabScope";
	public const string PropertyTabAttributeParamsBothNull = "PropertyTabAttributeParamsBothNull";
	public const string PropertyTabAttributeTypeLoadException = "PropertyTabAttributeTypeLoadException";
	public const string ToStringNull = "(null)";
	public const string ToolboxItemAttributeFailedGetType = "ToolboxItemAttributeFailedGetType";
	public const string TypeDescriptorAlreadyAssociated = "TypeDescriptorAlreadyAssociated";
	public const string TypeDescriptorArgsCountMismatch = "TypeDescriptorArgsCountMismatch";
	public const string TypeDescriptorExpectedElementType = "TypeDescriptorExpectedElementType";
	public const string TypeDescriptorProviderError = "TypeDescriptorProviderError";
	public const string TypeDescriptorSameAssociation = "TypeDescriptorSameAssociation";
	public const string TypeDescriptorUnsupportedRemoteObject = "TypeDescriptorUnsupportedRemoteObject";
	public const string toStringNone = "(none)";

	public const string Arg_EnumIllegalVal = "Arg_EnumIllegalVal";
	public const string Argument_InvalidClassAttribute = "Argument_InvalidClassAttribute";
	public const string Argument_InvalidPermissionState = "Argument_InvalidPermissionState";
	public const string Argument_WrongType = "Argument_WrongType";		
}
