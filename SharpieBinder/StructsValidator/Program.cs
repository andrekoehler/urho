﻿using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using Urho;
using Type = System.Type;

namespace StructsValidator
{
	class Program
	{
		static string codeContent;

		static void Main(string[] args)
		{
			//get all structs from Urho.dll
			var structs = typeof (UrhoObject).Assembly.GetTypes().Where(t => t.IsValueType && !t.IsPrimitive && !t.IsEnum).ToArray();
			
			// only those with Sequential layout and Sizeof > 1 (not empty)
			var notEmptyStructs = structs.Where(t => !t.IsAutoLayout && Marshal.SizeOf(t) > 1).ToArray();

			bool is64 = IntPtr.Size == 8;

			AppendC("// THIS CODE IS AUTOGENERATED BY SharpieBinder/StructsValidator\n");
			AppendC(is64
				? "#if defined(_MSC_VER) && (defined(_WIN64) || defined(__x86_64__) || defined(__ppc64__)) // generated for x64 only\n"
				: "#if defined(_MSC_VER) && !defined(_WIN64) && !defined(__x86_64__) && !defined(__ppc64__) // generated for x86 only\n");

			AppendC("using namespace Urho3D;\n");
			AppendC("void check_bindings_offsets()\n{");

			foreach (var type in notEmptyStructs)
				AddTest(type);

			AppendC("}");
			AppendC("#endif");
			AppendC($"\n/* Empty structs (stubs?):\n\n  {string.Join("\n  ", structs.Where(t => Marshal.SizeOf(t) <= 1).Select(t => t.Name).ToArray())}\n\n*/");
			File.WriteAllText("../../../../bindings/Native/asserts_" + (is64 ? "64.h" : "32.h"), codeContent);
		}

		static void AddTest(Type type)
		{
			if (type.FullName.StartsWith("Urho.Holo"))
				return;

			var managedName = type.Name;
			var nativeName = ResolveUrhoType(managedName);
			if (nativeName == null)
				return;

			var size = Marshal.SizeOf(type);
			AppendC($"\n\t// {managedName}:");
			AppendC($"\tstatic_assert(sizeof({nativeName}) == {size}, \"{managedName} has wrong size ({size})\");");
			foreach (var field in type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
			{
				var managedFieldName = field.Name;
				var nativeFieldName = ResolveUrhoTypeField(managedName, managedFieldName);
				if (string.IsNullOrEmpty(nativeFieldName))
					continue;
				var offset = Marshal.OffsetOf(type, managedFieldName);
				AppendC($"\tstatic_assert(offsetof({nativeName}, {nativeFieldName}) == {offset}, \"{managedName}.{managedFieldName} has wrong offset ({offset})\");");
			}
		}

		static string ResolveUrhoTypeField(string typeName, string fieldName)
		{
			fieldName = fieldName.Trim('_');
			fieldName = char.ToLowerInvariant(fieldName[0]) + fieldName.Substring(1);

			if (fieldName.EndsWith("Ptr")) fieldName = fieldName.Remove(fieldName.Length - 3);
			if (fieldName.EndsWith("Id")) fieldName = fieldName.Remove(fieldName.Length - 2) + "ID";

			if (typeName == "VariantValue") return null; //it's complicated, let's just verify it's sizeof
			if (typeName == "BiasParameters" && fieldName == "slopeScaleBias") return "slopeScaledBias_";
			if (typeName == "AnimationTriggerPoint" && fieldName == "variant") return "data_";
			if (typeName == "CompressedLevel" && fieldName == "imageData") return "data_";
			if (typeName == "CompressedLevel" && fieldName == "rowCount") return "rows_";
			if (typeName == "Matrix3") return fieldName.Replace("C","").Replace("r", "m") + "_";
			if (typeName == "RenderPathCommand" && fieldName.StartsWith("textureName")) return string.Empty;

			if (typeName != "CrowdObstacleAvoidanceParams") fieldName += "_";
			return fieldName;
		}

		static string ResolveUrhoType(string name)
		{
			string[] ignoredTypes = {
				"CustomGeometryVertex",
				"VariantValueLine",
				"BezierConfig",
				"CollisionData",
				"StringHashRef",
				"StringHash",
				"Iterator",
				"AttributeInfo",
				"ProfilerBlock",
				"WeakPtr",
				"VectorBase",
				"Variant",
				"Quaternion",
				"Matrix4",
				"UrhoString",
				"TypeInfo",
				"HashBase",
				"CascadeParameters",
			};

			if (name.EndsWith("EventArgs") || 
				ignoredTypes.Contains(name) ||
				//code-generated structs:
				name.Contains("__StaticArrayInitTypeSize") ||
				name.Contains("__FixedBuffer"))
				return null;

			if (name == "UrhoString")
				return "String";

			return name;
		}

		static void AppendC(string line)
		{
			codeContent += line + "\n";
		}
	}
}
