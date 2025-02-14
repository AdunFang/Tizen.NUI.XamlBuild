using System;
using System.Collections.Generic;

using Mono.Cecil;
using Mono.Cecil.Cil;

using Tizen.NUI.Xaml;

namespace Tizen.NUI.Xaml.Build.Tasks
{
	class ILContext
	{
		public ILContext(ILProcessor il, MethodBody body, ModuleDefinition module, FieldDefinition parentContextValues = null)
		{
			IL = il;
			Body = body;
			Values = new Dictionary<IValueNode, object>();
			Variables = new Dictionary<IElementNode, VariableDefinition>();
			Scopes = new Dictionary<INode, Tuple<VariableDefinition, IList<string>>>();
			TypeExtensions = new Dictionary<INode, TypeReference>();
			ParentContextValues = parentContextValues;
			Module = module;
		}

		public Dictionary<IValueNode, object> Values { get; private set; }

		public Dictionary<IElementNode, VariableDefinition> Variables { get; private set; }

		public Dictionary<INode, Tuple<VariableDefinition, IList<string>>> Scopes { get; private set; }

		public Dictionary<INode, TypeReference> TypeExtensions { get; }

		public FieldDefinition ParentContextValues { get; private set; }

		public object Root { get; set; } //FieldDefinition or VariableDefinition

		public ILProcessor IL { get; private set; }

		public MethodBody Body { get; private set; }

		public ModuleDefinition Module { get; private set; }
	}
}