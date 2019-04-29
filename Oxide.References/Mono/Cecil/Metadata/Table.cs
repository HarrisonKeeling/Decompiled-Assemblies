using System;

namespace Mono.Cecil.Metadata
{
	internal enum Table : byte
	{
		Module,
		TypeRef,
		TypeDef,
		FieldPtr,
		Field,
		MethodPtr,
		Method,
		ParamPtr,
		Param,
		InterfaceImpl,
		MemberRef,
		Constant,
		CustomAttribute,
		FieldMarshal,
		DeclSecurity,
		ClassLayout,
		FieldLayout,
		StandAloneSig,
		EventMap,
		EventPtr,
		Event,
		PropertyMap,
		PropertyPtr,
		Property,
		MethodSemantics,
		MethodImpl,
		ModuleRef,
		TypeSpec,
		ImplMap,
		FieldRVA,
		EncLog,
		EncMap,
		Assembly,
		AssemblyProcessor,
		AssemblyOS,
		AssemblyRef,
		AssemblyRefProcessor,
		AssemblyRefOS,
		File,
		ExportedType,
		ManifestResource,
		NestedClass,
		GenericParam,
		MethodSpec,
		GenericParamConstraint
	}
}